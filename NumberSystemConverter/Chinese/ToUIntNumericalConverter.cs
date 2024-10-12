using NC = DoenaSoft.NumberSystemConverter.Chinese.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class ToUIntNumericalConverter
{
    private delegate ulong Get10pXPartCallback(string input, char character, ulong factor);

    private const char C0A = '〇';
    private const char C0B = '空';
    private const char C0C = '洞';
    private const char C1A = '幺';
    private const char C1B = '蜀';
    private const char C2A = '两';
    private const char C2B = '兩';
    private const char C2C = '俩';
    private const char C2D = '倆';
    private const char C3A = '仨';
    private const char C7A = '拐';
    private const char C9A = '勾';
    private const char C10A = '呀';
    private const char C20A = '念';
    private const char C20B = '廿';
    private const char C30A = '卅';
    private const char C40A = '卌';
    private const char C200A = '皕';

    private static readonly Dictionary<char, ulong> _alternates;

    private readonly INumeralCharacters _numeralCharacters;

    static ToUIntNumericalConverter()
    {
        _alternates = new()
        {
            { C0A, 0 },
            { C0B, 0 },
            { C0C, 0 },
            { C1A, 1 },
            { C1B, 1 },
            { C2A, 2 },
            { C2B, 2 },
            { C2C, 2 },
            { C2D, 2 },
            { C3A, 3 },
            { C7A, 7 },
            { C9A, 9 },
            { C10A, 10 },
            { C20A, 20 },
            { C20B, 20 },
            { C30A, 30 },
            { C40A, 40 },
            { C200A, 200 },
        };
    }

    internal ToUIntNumericalConverter(INumeralCharacters numeralCharacters)
    {
        _numeralCharacters = numeralCharacters;
    }

    public ulong ToUInt(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        var validCharachters = _numeralCharacters.SingleDigits
            .Concat([_numeralCharacters.C10, _numeralCharacters.C100, _numeralCharacters.C1000, _numeralCharacters.C1_0000, _numeralCharacters.C1_0000_0000, _numeralCharacters.C1_0000_0000_0000, _numeralCharacters.C1_0000_0000_0000_0000, _numeralCharacters.C1_0000_0000_0000_0000_0000])
            .Concat(_alternates.Keys)
            .ToList();

        if (input.Any(c => !validCharachters.Contains(c)))
        {
            throw new InvalidInputException("Invalid character in input");
        }

        var result = this.Get10p20Part(input);

        return result;
    }

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

    private static string[] GetSplit(string input, char splitCharacter)
    {
        var split = input.Split(splitCharacter);

        if (split.Length > 2)
        {
            throw new InvalidInputException("Input is not valid");
        }

        return split;
    }

    private ulong Get10pXPart(string input, char character, ulong factor)
    {
        var split = GetSplit(input, character);

        var (nextFunction, nextCharacter, nextFactor) = this.GetNextFunction(factor);

        ulong upperPart;
        ulong lowerPart;
        if (split.Length == 2)
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
                    return (this.Get100Part, _numeralCharacters.C100, NC.D100);
                }
            case NC.D100:
                {
                    return (this.Get10Part, _numeralCharacters.C10, NC.D10);
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

    private ulong Get100Part(string input, char character, ulong factor)
    {
        var split = GetSplit(input, character);

        var containsSpecialCharacter = false;
        var foundSpecialCharacter = ' ';
        var characterValue = 0UL;
        ContainsSpecialCharacter(input, C200A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);

        var (nextFunction, nextCharacter, nextFactor) = this.GetNextFunction(factor);

        ulong upperPart;
        ulong lowerPart;
        if (containsSpecialCharacter)
        {
            split = input.Split(foundSpecialCharacter);

            upperPart = characterValue / factor;

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

        var containsSpecialCharacter = false;
        var foundSpecialCharacter = ' ';
        var characterValue = 0UL;
        ContainsSpecialCharacter(input, C10A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C20A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C20B, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C30A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C40A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);

        var nextFunction = this.Get1Part;

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

            lowerPart = nextFunction(split[1]);
        }
        else if (split.Length == 2)
        {
            upperPart = split[0].Length > 0
                ? nextFunction(split[0])
                : 1U;

            lowerPart = split[1].Length > 0
                ? nextFunction(split[1])
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = nextFunction(split[0]);
        }

        var result = CalculateResult(upperPart, lowerPart, NC.D10);

        return result;
    }

    private ulong Get1Part(string input)
    {
        var lowerPart = input.Length > 1
            ? input.TrimStart(_numeralCharacters.SingleDigits[0], C0A, C0B, C0C)
            : input;

        if (lowerPart.Length > 1)
        {
            throw new InvalidInputException("Input is not valid");
        }
        else if (lowerPart.Length < (input.Length - 1))
        {
            throw new InvalidInputException("Input is not valid");
        }

        var character = lowerPart[0];

        if (!_alternates.TryGetValue(character, out var result))
        {
            result = (ulong)Array.IndexOf(_numeralCharacters.SingleDigits, character);
        }

        return result;
    }

    private static void ContainsSpecialCharacter(string input
        , char specialCharacterToLookFor
        , ref bool alreadyContainsSpecialCharacter
        , ref string[] split
        , ref char foundSpecialCharacter
        , ref ulong characterValue)
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

            var newSplit = input.Split(specialCharacterToLookFor);

            if (newSplit.Length > 2)
            {
                throw new InvalidInputException("Input is not valid");
            }
            else if (!string.IsNullOrEmpty(newSplit[0]))
            {
                throw new InvalidInputException("Input is not valid");
            }

            alreadyContainsSpecialCharacter = containsThisSpecialCharacter;

            split = newSplit;

            foundSpecialCharacter = specialCharacterToLookFor;

            characterValue = _alternates[specialCharacterToLookFor];
        }
    }
}