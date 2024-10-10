using System.Text;
using NC = DoenaSoft.NumberSystemConverter.Roman.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Roman;

public sealed class NumeralConverter : INumberSystemConverter
{
    public string FromUInt(uint input)
    {
        if (input == 0)
        {
            throw new ArgumentException("Number must be bigger than 0", nameof(input));
        }

        var number = input;

        var thousands = GetMultiple(ref number, NC.OneThousand);
        var hasNineHundred = HasCompund(ref number, NC.OneThousand - NC.OneHundred);
        var hasFiveHundred = HasCompund(ref number, NC.FiveHundred);
        var hasFourHundred = HasCompund(ref number, NC.FiveHundred - NC.OneHundred);
        var hundreds = GetMultiple(ref number, NC.OneHundred);
        var hasNinety = HasCompund(ref number, NC.OneHundred - NC.Ten);
        var hasFifty = HasCompund(ref number, NC.Fifty);
        var hasForty = HasCompund(ref number, NC.Fifty - NC.Ten);
        var tens = GetMultiple(ref number, NC.Ten);
        var hasNine = HasCompund(ref number, NC.Ten - NC.One);
        var hasFive = HasCompund(ref number, NC.Five);
        var hasFour = HasCompund(ref number, NC.Five - NC.One);
        var ones = GetMultiple(ref number, NC.One);

        var resultBuilder = new StringBuilder();

        AddMultiple(resultBuilder, thousands, $"{NC.M}");
        AddCompound(resultBuilder, hasNineHundred, $"{NC.C}{NC.M}");
        AddCompound(resultBuilder, hasFiveHundred, $"{NC.D}");
        AddCompound(resultBuilder, hasFourHundred, $"{NC.C}{NC.D}");
        AddMultiple(resultBuilder, hundreds, $"{NC.C}");
        AddCompound(resultBuilder, hasNinety, $"{NC.X}{NC.C}");
        AddCompound(resultBuilder, hasFifty, $"{NC.L}");
        AddCompound(resultBuilder, hasForty, $"{NC.X}{NC.L}");
        AddMultiple(resultBuilder, tens, $"{NC.X}");
        AddCompound(resultBuilder, hasNine, $"{NC.I}{NC.X}");
        AddCompound(resultBuilder, hasFive, $"{NC.V}");
        AddCompound(resultBuilder, hasFour, $"{NC.I}{NC.V}");
        AddMultiple(resultBuilder, ones, $"{NC.I}");

        return resultBuilder.ToString();
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
        for (uint i = 0; i < count; i++)
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
}