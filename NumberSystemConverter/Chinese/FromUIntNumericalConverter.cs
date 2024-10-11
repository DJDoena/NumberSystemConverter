using System.Text;
using NC = DoenaSoft.NumberSystemConverter.Chinese.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class FromUIntNumericalConverter
{
    private readonly INumeralCharacters _numeralCharacters;

    internal FromUIntNumericalConverter(INumeralCharacters numeralCharacters)
    {
        _numeralCharacters = numeralCharacters;
    }

    public string FromUInt(uint input)
    {
        if (input == 0)
        {
            return _numeralCharacters.SingleDigits[0].ToString();
        }

        var resultBuilder = new StringBuilder();

        this.FromUInt(input, resultBuilder, 1U);

        var result = resultBuilder.ToString();

        return result;
    }

    private void FromUInt(uint input
        , StringBuilder resultBuilder
        , uint previousDivider)
    {
        var number = input;

        var bigNumber = false;

        var missingPosition = false;

        if (number >= NC.D100_000_000)
        {
            this.ReduceMultipe(ref number, resultBuilder, NC.D100_000_000, _numeralCharacters.C100_000_000, bigNumber, missingPosition, previousDivider);

            missingPosition = false;

            bigNumber = true;

            previousDivider = NC.D100_000_000;
        }

        if (number >= NC.D10_000)
        {
            this.ReduceMultipe(ref number, resultBuilder, NC.D10_000, _numeralCharacters.C10_000, bigNumber, missingPosition, previousDivider);

            bigNumber = true;

            missingPosition = false;

            previousDivider = NC.D10_000;
        }
        else if (bigNumber)
        {
            missingPosition = true;
        }

        if (number >= NC.D1_000)
        {
            this.ReduceMultipe(ref number, resultBuilder, NC.D1_000, _numeralCharacters.C1_000, bigNumber, missingPosition, previousDivider);

            bigNumber = true;

            missingPosition = false;

            previousDivider = NC.D1_000;
        }
        else if (bigNumber)
        {
            missingPosition = true;
        }

        if (number >= NC.D100)
        {
            this.ReduceMultipe(ref number, resultBuilder, NC.D100, _numeralCharacters.C100, bigNumber, missingPosition, previousDivider);

            bigNumber = true;

            missingPosition = false;

            previousDivider = NC.D100;
        }
        else if (bigNumber)
        {
            missingPosition = true;
        }

        if (number >= NC.D10)
        {
            this.ReduceMultipe(ref number, resultBuilder, NC.D10, _numeralCharacters.C10, bigNumber, missingPosition, previousDivider, omitOne: true);

            missingPosition = false;
        }
        else if (bigNumber)
        {
            missingPosition = true;
        }

        this.ProcessOnes(ref number, resultBuilder, bigNumber, missingPosition);
    }

    private uint ReduceMultipe(ref uint number
        , StringBuilder resultBuilder
        , uint divider
        , char character
        , bool bigNumber
        , bool missingPosition
        , uint previousDivider
        , bool omitOne = false)
    {
        var quotient = number / divider;

        var subResultBuilder = new StringBuilder();

        var zeroInserted = false;


        if (previousDivider != 1U
            && divider == NC.D10_000
            && quotient < NC.D100
            && quotient > 1U)
        {
            resultBuilder.Append(_numeralCharacters.SingleDigits[0]);

            zeroInserted = true;
        }

        if (quotient != 1U || !omitOne)
        {
            this.FromUInt(quotient, subResultBuilder, previousDivider);
        }

        number -= quotient * divider;

        if (!zeroInserted
            && bigNumber
            && missingPosition)
        {
            resultBuilder.Append(_numeralCharacters.SingleDigits[0]);
        }

        resultBuilder.Append(subResultBuilder.ToString());
        resultBuilder.Append(character);

        return number;
    }

    private void ProcessOnes(ref uint number
        , StringBuilder resultBuilder
        , bool bigNumber
        , bool missingPosition)
    {
        if (number > 0U)
        {
            if (bigNumber && missingPosition)
            {
                resultBuilder.Append(_numeralCharacters.SingleDigits[0]);
            }

            resultBuilder.Append(_numeralCharacters.SingleDigits[number]);
        }

        number = 0;
    }
}
