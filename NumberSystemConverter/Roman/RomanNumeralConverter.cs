using System.Text;
using NC = DoenaSoft.NumberSystemConverter.Roman.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Roman;

/// <summary>
/// Converter for Roman numeral system.
/// Converts between decimal numbers (ulong) and Roman numeral strings (I, V, X, L, C, D, M).
/// Note: Roman numerals do not support zero.
/// </summary>
public sealed class RomanNumeralConverter : INumberSystemConverter
{
    /// <inheritdoc/>
    /// <exception cref="InvalidInputException">Thrown when input is 0, as Roman numerals do not support zero.</exception>
    public string FromULong(ulong input)
    {
        if (input == 0)
        {
            throw new InvalidInputException("Input must be bigger than 0. Roman numerals did not have the conzept of 0.");
        }

        var number = input;

        var thousands = GetMultiple(ref number, NC.D1000);
        var hasNineHundred = HasCompound(ref number, NC.D1000 - NC.D100);
        var hasFiveHundred = HasCompound(ref number, NC.D500);
        var hasFourHundred = HasCompound(ref number, NC.D500 - NC.D100);
        var hundreds = GetMultiple(ref number, NC.D100);
        var hasNinety = HasCompound(ref number, NC.D100 - NC.D10);
        var hasFifty = HasCompound(ref number, NC.D50);
        var hasForty = HasCompound(ref number, NC.D50 - NC.D10);
        var tens = GetMultiple(ref number, NC.D10);
        var hasNine = HasCompound(ref number, NC.D10 - NC.D1);
        var hasFive = HasCompound(ref number, NC.D5);
        var hasFour = HasCompound(ref number, NC.D5 - NC.D1);
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

    /// <inheritdoc/>
    /// <exception cref="ArgumentNullException">Thrown when input is null or whitespace.</exception>
    /// <exception cref="InvalidInputException">Thrown when input contains invalid Roman numeral characters.</exception>
    public ulong ToULong(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        input = input.ToUpper();

        var numbers = (new RomanNumeralInputValidator().Validate(input))!;

        var result = 0UL;

        foreach (var number in numbers)
        {
            result += number;
        }

        return result;
    }

    #region FromUInt
    private static ulong GetMultiple(ref ulong number
        , ulong segment)
    {
        if (number >= segment)
        {
            var multiple = number / segment;

            number -= multiple * segment;

            return multiple;
        }
        else
        {
            return 0;
        }
    }

    private static bool HasCompound(ref ulong number
        , ulong segment)
    {
        var hasCompound = number >= segment;

        if (hasCompound)
        {
            number -= segment;
        }

        return hasCompound;
    }

    private static void AddMultiple(StringBuilder resultBuilder
        , ulong count
        , string numeral)
    {
        for (ulong i = 0; i < count; i++)
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