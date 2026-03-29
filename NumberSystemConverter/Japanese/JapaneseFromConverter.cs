using DoenaSoft.NumberSystemConverter.EastAsia;
using System.Text;

namespace DoenaSoft.NumberSystemConverter.Japanese;

internal sealed class JapaneseFromConverter(IEastAsia10p4NumeralCharacters numeralCharacters)
    : EastAsiaFrom10p4ConverterBase(numeralCharacters)
{
    protected override string ToCharacters(ulong input)
    {
        var (thousands, hundreds, tens, ones) = ParseDigits(input);

        var resultBuilder = new StringBuilder();

        this.AppendWithOptionalDigit(resultBuilder, thousands, _numeralCharacters.C1000);
        this.AppendWithOptionalDigit(resultBuilder, hundreds, _numeralCharacters.C100);
        this.AppendWithOptionalDigit(resultBuilder, tens, _numeralCharacters.C10);

        if (ones > 0)
        {
            resultBuilder.Append(_numeralCharacters.SingleDigits[ones]);
        }

        var result = resultBuilder.ToString();

        return result;
    }
}