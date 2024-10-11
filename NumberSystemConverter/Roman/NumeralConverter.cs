using System.Text;
using NC = DoenaSoft.NumberSystemConverter.Roman.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Roman;

public sealed class NumeralConverter : INumberSystemConverter
{
    public string FromUInt(uint input)
    {
        if (input == 0)
        {
            throw new InvalidInputException("Input must be bigger than 0. Roman numerals did not have the conzept of 0.");
        }

        var number = input;

        var thousands = GetMultiple(ref number, NC.D1000);
        var hasNineHundred = HasCompund(ref number, NC.D1000 - NC.D100);
        var hasFiveHundred = HasCompund(ref number, NC.D500);
        var hasFourHundred = HasCompund(ref number, NC.D500 - NC.D100);
        var hundreds = GetMultiple(ref number, NC.D100);
        var hasNinety = HasCompund(ref number, NC.D100 - NC.D10);
        var hasFifty = HasCompund(ref number, NC.D50);
        var hasForty = HasCompund(ref number, NC.D50 - NC.D10);
        var tens = GetMultiple(ref number, NC.D10);
        var hasNine = HasCompund(ref number, NC.D10 - NC.D1);
        var hasFive = HasCompund(ref number, NC.D5);
        var hasFour = HasCompund(ref number, NC.D5 - NC.D1);
        var ones = GetMultiple(ref number, NC.D1);

        var resultBuilder = new StringBuilder();

        AddMultiple(resultBuilder, thousands, $"{NC.R1000}");
        AddCompound(resultBuilder, hasNineHundred, $"{NC.R100}{NC.R1000}");
        AddCompound(resultBuilder, hasFiveHundred, $"{NC.R500}");
        AddCompound(resultBuilder, hasFourHundred, $"{NC.R100}{NC.R500}");
        AddMultiple(resultBuilder, hundreds, $"{NC.R100}");
        AddCompound(resultBuilder, hasNinety, $"{NC.R10}{NC.R100}");
        AddCompound(resultBuilder, hasFifty, $"{NC.R50}");
        AddCompound(resultBuilder, hasForty, $"{NC.R10}{NC.R50}");
        AddMultiple(resultBuilder, tens, $"{NC.R10}");
        AddCompound(resultBuilder, hasNine, $"{NC.R1}{NC.R10}");
        AddCompound(resultBuilder, hasFive, $"{NC.R5}");
        AddCompound(resultBuilder, hasFour, $"{NC.R1}{NC.R5}");
        AddMultiple(resultBuilder, ones, $"{NC.R1}");

        var result = resultBuilder.ToString();

        return result;
    }

    public uint ToUInt(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        input = input.ToUpper();

        var numbers = (new NumeralInputValidator().Validate(input))!;

        var result = 0U;

        foreach (var number in numbers)
        {
            result += number;
        }

        return result;
    }

    #region FromUInt
    private static uint GetMultiple(ref uint number, uint segment)
    {
        if (number >= segment)
        {
            var result = number / segment;

            number -= result * segment;

            return result;
        }
        else
        {
            return 0;
        }
    }

    private static bool HasCompund(ref uint number, uint segment)
    {
        var result = number >= segment;

        if (result)
        {
            number -= segment;
        }

        return result;
    }

    private static void AddMultiple(StringBuilder resultBuilder
        , uint count
        , string numeral)
    {
        for (var i = 0; i < count; i++)
        {
            resultBuilder.Append(numeral);
        }
    }

    private static void AddCompound(StringBuilder resultBuilder
        , bool hasCompound
        , string numeral)
    {
        if (hasCompound)
        {
            resultBuilder.Append(numeral);
        }
    }

    #endregion
}