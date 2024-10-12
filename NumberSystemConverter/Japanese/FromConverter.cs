using System.Text;
using DoenaSoft.NumberSystemConverter.EastAsia;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Japanese;

internal sealed class FromConverter(I10p4NumeralCharacters numeralCharacters)
    : From10p4ConverterBase(numeralCharacters)
{
    protected override string ToCharacters(ulong input)
    {
        var number = input;

        var thousands = number / NC.D1000;

        number -= thousands * NC.D1000;

        var hundreds = number / NC.D100;

        number -= hundreds * NC.D100;

        var tens = number / NC.D10;

        number -= tens * NC.D10;

        var ones = number;

        var resultBuilder = new StringBuilder();

        if (thousands > 1)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[thousands]}{_numeralCharacters.C1000}");
        }
        else if (thousands == 1)
        {
            resultBuilder.Append($"{_numeralCharacters.C1000}");
        }

        if (hundreds > 1)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[hundreds]}{_numeralCharacters.C100}");
        }
        else if (hundreds == 1)
        {
            resultBuilder.Append($"{_numeralCharacters.C100}");
        }

        if (tens > 1)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[tens]}{_numeralCharacters.C10}");
        }
        else if (tens == 1)
        {
            resultBuilder.Append($"{_numeralCharacters.C10}");
        }

        if (ones > 0)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[ones]}");
        }

        var result = resultBuilder.ToString();

        return result;
    }
}