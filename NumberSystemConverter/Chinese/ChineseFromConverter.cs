using DoenaSoft.NumberSystemConverter.EastAsia;
using System.Text;

namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class ChineseFromConverter(IEastAsia10p4NumeralCharacters numeralCharacters)
    : EastAsiaFrom10p4ConverterBase(numeralCharacters)
{
    /// <summary>
    /// Converts a number (0-9999) to Chinese characters.
    /// Chinese numbering requires zero placeholders when skipping place values.
    /// Example: 1001 = "一千零一" (one-thousand-zero-one).
    /// </summary>
    protected override string ToCharacters(ulong input)
    {
        var (thousands, hundreds, tens, ones) = ParseDigits(input);

        var state = new ConversionState(thousands, hundreds, tens, ones, new StringBuilder());

        var zeroInserted = false;

        this.AppendThousands(state, ref zeroInserted);

        this.AppendHundreds(state, ref zeroInserted);

        this.AppendTens(state, ref zeroInserted);

        this.AppendOnes(state);

        return state.ResultBuilder.ToString();
    }

    /// <summary>
    /// Appends the thousands place to the result.
    /// If no thousands but has lower places, starts with zero for proper inter-section handling.
    /// </summary>
    private void AppendThousands(ConversionState state
        , ref bool zeroInserted)
    {
        if (state.Thousands > 0)
        {
            state.ResultBuilder.Append(_numeralCharacters.SingleDigits[state.Thousands]);
            state.ResultBuilder.Append(_numeralCharacters.C1000);
        }
        else if (state.Hundreds > 0 || state.Tens > 0 || state.Ones > 0)
        {
            state.ResultBuilder.Append(this.GetZero());

            zeroInserted = true;
        }
    }

    /// <summary>
    /// Appends the hundreds place to the result.
    /// </summary>
    private void AppendHundreds(ConversionState state
        , ref bool zeroInserted)
    {
        if (state.Hundreds > 0)
        {
            state.ResultBuilder.Append(_numeralCharacters.SingleDigits[state.Hundreds]);
            state.ResultBuilder.Append(_numeralCharacters.C100);

            zeroInserted = false;
        }
        else if (!zeroInserted && (state.Tens > 0 || state.Ones > 0))
        {
            state.ResultBuilder.Append(this.GetZero());
            zeroInserted = true;
        }
    }

    /// <summary>
    /// Appends the tens place to the result.
    /// Special rule: "10" alone = "十" but with higher places = "一十".
    /// </summary>
    private void AppendTens(ConversionState state
        , ref bool zeroInserted)
    {
        if (state.Tens > 1)
        {
            state.ResultBuilder.Append(_numeralCharacters.SingleDigits[state.Tens]);
            state.ResultBuilder.Append(_numeralCharacters.C10);
        }
        else if (state.Tens == 1)
        {
            var hasHigherPlaces = state.Thousands > 0 || state.Hundreds > 0;

            if (hasHigherPlaces)
            {
                state.ResultBuilder.Append(_numeralCharacters.SingleDigits[state.Tens]);
            }

            state.ResultBuilder.Append(_numeralCharacters.C10);
        }
        else if (!zeroInserted && state.Ones > 0)
        {
            state.ResultBuilder.Append(this.GetZero());
        }
    }

    /// <summary>
    /// Appends the ones place to the result.
    /// When input is 0 (all places are zero), outputs "零".
    /// </summary>
    private void AppendOnes(ConversionState state)
    {
        if (state.Ones > 0)
        {
            state.ResultBuilder.Append(_numeralCharacters.SingleDigits[state.Ones]);
        }
        else if (state.Thousands == 0 && state.Hundreds == 0 && state.Tens == 0)
        {
            state.ResultBuilder.Append(_numeralCharacters.SingleDigits[state.Ones]);
        }
    }

    private readonly struct ConversionState
    {
        public ulong Thousands { get; }

        public ulong Hundreds { get; }

        public ulong Tens { get; }

        public ulong Ones { get; }

        public StringBuilder ResultBuilder { get; }

        public ConversionState(ulong thousands
            , ulong hundreds
            , ulong tens
            , ulong ones
            , StringBuilder resultBuilder)
        {
            this.Thousands = thousands;
            this.Hundreds = hundreds;
            this.Tens = tens;
            this.Ones = ones;
            this.ResultBuilder = resultBuilder;
        }
    }
}