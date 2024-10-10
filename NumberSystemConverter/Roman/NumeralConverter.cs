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

        var thousands = ReduceMultiple(ref number, NC.OneThousand);
        var hasNineHundred = HasLimit(ref number, NC.OneThousand - NC.OneHundred);
        var hasFiveHundred = HasLimit(ref number, NC.FiveHundred);
        var hasFourHundred = HasLimit(ref number, NC.FiveHundred - NC.OneHundred);
        var hundreds = ReduceMultiple(ref number, NC.OneHundred);
        var hasNinety = HasLimit(ref number, NC.OneHundred - NC.Ten);
        var hasFifty = HasLimit(ref number, NC.Fifty);
        var hasForty = HasLimit(ref number, NC.Fifty - NC.Ten);
        var tens = ReduceMultiple(ref number, NC.Ten);
        var hasNine = HasLimit(ref number, NC.Ten - NC.One);
        var hasFive = HasLimit(ref number, NC.Five);
        var hasFour = HasLimit(ref number, NC.Five - NC.One);
        var ones = ReduceMultiple(ref number, NC.One);

        var result = new StringBuilder();

        AddMultiple(result, thousands, $"{NC.M}");
        AddLimit(result, hasNineHundred, $"{NC.C}{NC.M}");
        AddLimit(result, hasFiveHundred, $"{NC.D}");
        AddLimit(result, hasFourHundred, $"{NC.C}{NC.D}");
        AddMultiple(result, hundreds, $"{NC.C}");
        AddLimit(result, hasNinety, $"{NC.X}{NC.C}");
        AddLimit(result, hasFifty, $"{NC.L}");
        AddLimit(result, hasForty, $"{NC.X}{NC.L}");
        AddMultiple(result, tens, $"{NC.X}");
        AddLimit(result, hasNine, $"{NC.I}{NC.X}");
        AddLimit(result, hasFive, $"{NC.V}");
        AddLimit(result, hasFour, $"{NC.I}{NC.V}");
        AddMultiple(result, ones, $"{NC.I}");

        return result.ToString();
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

    private static uint ReduceMultiple(ref uint number, uint segment)
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

    private static bool HasLimit(ref uint number, uint segment)
    {
        var hasLimit = number >= segment;

        if (hasLimit)
        {
            number -= segment;
        }

        return hasLimit;
    }

    private static void AddMultiple(StringBuilder result, uint count, string numeral)
    {
        for (uint i = 0; i < count; i++)
        {
            result.Append(numeral);
        }
    }

    private static void AddLimit(StringBuilder result, bool hasLimit, string numeral)
    {
        if (hasLimit)
        {
            result.Append(numeral);
        }
    }
}