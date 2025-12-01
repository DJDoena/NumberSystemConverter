using NC = DoenaSoft.NumberSystemConverter.EastAsia.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.EastAsia;

internal abstract class To10p4ConverterBase(I10p4NumeralCharacters numeralCharacters)
{
    protected delegate ulong Get10pXPartCallback(string input, char character, ulong factor);

    protected readonly I10p4NumeralCharacters _numeralCharacters = numeralCharacters;

    public ulong Convert(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        var validCharachters = _numeralCharacters.SingleDigits
            .Concat([_numeralCharacters.C10, _numeralCharacters.C100, _numeralCharacters.C1000, _numeralCharacters.C1_0000, _numeralCharacters.C1_0000_0000, _numeralCharacters.C1_0000_0000_0000, _numeralCharacters.C1_0000_0000_0000_0000, _numeralCharacters.C1_0000_0000_0000_0000_0000])
            .Concat(this.GetAlternates())
            .ToList();

        if (input.Any(c => !validCharachters.Contains(c)))
        {
            var firstInvalidCharacter = input.First(c => !validCharachters.Contains(c));

            var indexOf = input.IndexOf(firstInvalidCharacter);

            throw new InvalidInputException($"Invalid character '{firstInvalidCharacter}' (index: {indexOf}) in input");
        }

        var result = this.Get10p20Part(input);

        return result;
    }

    protected abstract IEnumerable<char> GetAlternates();

    private ulong Get10p20Part(string input)
    {
        var split = GetSplit(input, _numeralCharacters.C1_0000_0000_0000_0000_0000);

        if (split.Length == 2)
        {
            throw new OverflowException("Input is too big");
        }

        var result = this.Get10pXPart(split[0], _numeralCharacters.C1_0000_0000_0000_0000, NC.D1_0000_0000_0000_0000);

        return result;
    }

    protected static string[] GetSplit(string input, char splitCharacter)
    {
        var split = input.Split(splitCharacter);

        if (split.Length > 2)
        {
            throw new InvalidInputException("Input is not valid");
        }

        return split;
    }

    protected ulong Get10pXPart(string input, char character, ulong factor)
    {
        var split = GetSplit(input, character);

        var (containsSpecialCharacter, foundSpecialCharacter, characterValue)
            = this.ContainsSpecialCharacter(input, factor, split);

        var (nextFunction, nextCharacter, nextFactor)
            = this.GetNextFunction(factor);

        ulong upperPart;
        ulong lowerPart;
        if (containsSpecialCharacter)
        {
            split = input.Split(foundSpecialCharacter);

            upperPart = !string.IsNullOrEmpty(split[0])
                ? nextFunction(split[0], nextCharacter, nextFactor)
                : characterValue / factor;

            lowerPart = split[1].Length > 0
                ? nextFunction(split[1], nextCharacter, nextFactor)
                : 0U;
        }
        else if (split.Length == 2)
        {
            upperPart = nextFunction(split[0], nextCharacter, nextFactor);

            lowerPart = split[1].Length > 0
                ? nextFunction(split[1], nextCharacter, nextFactor)
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = nextFunction(split[0], nextCharacter, nextFactor);
        }

        var result = CalculateResult(upperPart, lowerPart, factor);

        return result;
    }

    private ulong Get10Part(string input, char character, ulong factor)
    {
        var split = GetSplit(input, character);

        var (containsSpecialCharacter, foundSpecialCharacter, characterValue)
            = this.ContainsSpecialCharacter(input, factor, split);

        var (nextFunction, nextCharacter, nextFactor)
            = this.GetNextFunction(factor);

        ulong upperPart;
        ulong lowerPart;
        if (containsSpecialCharacter)
        {
            split = input.Split(foundSpecialCharacter);

            if (string.IsNullOrEmpty(split[1]))
            {
                throw new InvalidInputException("Input is not valid");
            }

            upperPart = characterValue / factor;

            lowerPart = nextFunction(split[1], nextCharacter, nextFactor);
        }
        else if (split.Length == 2)
        {
            upperPart = split[0].Length > 0
                ? nextFunction(split[0], nextCharacter, nextFactor)
                : 1U;

            lowerPart = split[1].Length > 0
                ? nextFunction(split[1], nextCharacter, nextFactor)
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = nextFunction(split[0], nextCharacter, nextFactor);
        }

        var result = CalculateResult(upperPart, lowerPart, factor);

        return result;
    }

    protected ulong Get1Part(string input, char _, ulong __)
    {
        var lowerPart = input.Length > 1
            ? input.TrimStart(_numeralCharacters.SingleDigits[0]).TrimStart(this.GetAlternateZeroCharacters())
            : input;

        if (lowerPart.Length == 0)
        {
            throw new InvalidInputException("Input is not valid");
        }
        else if (lowerPart.Length > 1)
        {
            throw new InvalidInputException("Input is not valid");
        }
        else if (lowerPart.Length < (input.Length - 1))
        {
            throw new InvalidInputException("Input is not valid");
        }

        var character = lowerPart[0];

        if (!this.TryGetAlternateCharacter(character, out var result))
        {
            result = (ulong)Array.IndexOf(_numeralCharacters.SingleDigits, character);
        }

        return result;
    }

    protected abstract char[] GetAlternateZeroCharacters();

    protected abstract bool TryGetAlternateCharacter(char character, out ulong value);

    protected abstract (bool containsSpecialCharacter, char foundSpecialCharacterout, ulong characterValue) ContainsSpecialCharacter(string input
        , ulong factor
        , string[] split);

    private (Get10pXPartCallback nextFunction, char nextCharacter, ulong nextFactor) GetNextFunction(ulong factor)
    {
        switch (factor)
        {
            case NC.D1_0000_0000_0000_0000:
                {
                    return (this.Get10pXPart, _numeralCharacters.C1_0000_0000_0000, NC.D1_0000_0000_0000);
                }
            case NC.D1_0000_0000_0000:
                {
                    return (this.Get10pXPart, _numeralCharacters.C1_0000_0000, NC.D1_0000_0000);
                }
            case NC.D1_0000_0000:
                {
                    return (this.Get10pXPart, _numeralCharacters.C1_0000, NC.D1_0000);
                }
            case NC.D1_0000:
                {
                    return (this.Get10pXPart, _numeralCharacters.C1000, NC.D1000);
                }
            case NC.D1000:
                {
                    return (this.Get10pXPart, _numeralCharacters.C100, NC.D100);
                }
            case NC.D100:
                {
                    return (this.Get10Part, _numeralCharacters.C10, NC.D10);
                }
            case NC.D10:
                {
                    return (this.Get1Part, '\0', 1);
                }
            default:
                {
                    throw new NotSupportedException();
                }
        }
    }

    private static ulong CalculateResult(ulong upperPart
        , ulong lowerPart
        , ulong factor)
    {
        try
        {
            var result = checked((upperPart * factor) + lowerPart);

            return result;
        }
        catch (OverflowException)
        {
            throw new OverflowException("Input is too big");
        }
    }

    protected void ContainsSpecialCharacter(string input
        , char specialCharacterToLookFor
        , ref bool alreadyContainsSpecialCharacter
        , string[] split
        , ref char foundSpecialCharacter
        , ref ulong characterValue
        , bool specialCharacterIsUnit = false)
    {
        var containsThisSpecialCharacter = input.Contains(specialCharacterToLookFor);

        if (containsThisSpecialCharacter && alreadyContainsSpecialCharacter)
        {
            throw new InvalidInputException("Input is not valid");
        }

        if (containsThisSpecialCharacter)
        {
            if (split.Length > 1)
            {
                throw new InvalidInputException("Input is not valid");
            }

            split = input.Split(specialCharacterToLookFor);

            if (split.Length > 2)
            {
                throw new InvalidInputException("Input is not valid");
            }
            else if (!specialCharacterIsUnit && !string.IsNullOrEmpty(split[0]))
            {
                throw new InvalidInputException("Input is not valid");
            }

            alreadyContainsSpecialCharacter = containsThisSpecialCharacter;

            foundSpecialCharacter = specialCharacterToLookFor;

            this.TryGetAlternateCharacter(specialCharacterToLookFor, out characterValue);
        }
    }
}