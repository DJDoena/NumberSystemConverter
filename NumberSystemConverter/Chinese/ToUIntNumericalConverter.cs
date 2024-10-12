using NC = DoenaSoft.NumberSystemConverter.Chinese.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class ToUIntNumericalConverter
{
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

    private static readonly Dictionary<char, uint> _alternates;

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

    public uint ToUInt(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        var validCharachters = _numeralCharacters.SingleDigits
            .Concat([_numeralCharacters.C10, _numeralCharacters.C100, _numeralCharacters.C1_000, _numeralCharacters.C10_000, _numeralCharacters.C100_000_000])
            .Concat(_alternates.Keys)
            .ToList();

        if (input.Any(c => !validCharachters.Contains(c)))
        {
            throw new InvalidInputException("Invalid character in input");
        }

        var result = this.GetHundredMillionsPart(input);

        return result;
    }

    private uint GetHundredMillionsPart(string input)
    {
        var split = input.Split(_numeralCharacters.C100_000_000);

        if (split.Length > 2)
        {
            throw new OverflowException("Input is too big");
        }

        uint upperPart;
        uint lowerPart;
        if (split.Length == 2)
        {
            upperPart = this.GetTenThousandsPart(split[0]);

            lowerPart = split[1].Length > 0
                ? this.GetTenThousandsPart(split[1])
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = this.GetTenThousandsPart(split[0]);
        }

        try
        {
            var result = checked((upperPart * NC.D100_000_000) + lowerPart);

            return result;
        }
        catch (OverflowException)
        {
            throw new OverflowException("Input is too big");
        }
    }

    private uint GetTenThousandsPart(string input)
    {
        var split = input.Split(_numeralCharacters.C10_000);

        if (split.Length > 2)
        {
            throw new InvalidInputException("Input is not valid");
        }

        uint upperPart;
        uint lowerPart;
        if (split.Length == 2)
        {
            upperPart = this.GetThousandsPart(split[0]);

            lowerPart = split[1].Length > 0
                ? this.GetThousandsPart(split[1])
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = this.GetThousandsPart(split[0]);
        }

        var result = (upperPart * NC.D10_000) + lowerPart;

        return result;
    }

    private uint GetThousandsPart(string input)
    {
        var split = input.Split(_numeralCharacters.C1_000);

        if (split.Length > 2)
        {
            throw new InvalidInputException("Input is not valid");
        }

        uint upperPart;
        uint lowerPart;
        if (split.Length == 2)
        {
            upperPart = this.GetHundredsPart(split[0]);

            lowerPart = split[1].Length > 0
                ? this.GetHundredsPart(split[1])
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = this.GetHundredsPart(split[0]);
        }

        var result = (upperPart * NC.D1_000) + lowerPart;

        return result;
    }

    private uint GetHundredsPart(string input)
    {
        var split = input.Split(_numeralCharacters.C100);

        if (split.Length > 2)
        {
            throw new InvalidInputException("Input is not valid");
        }

        var containsSpecialCharacter = false;
        var foundSpecialCharacter = ' ';
        var characterValue = 0U;
        ContainsSpecialCharacter(input, C200A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);

        uint upperPart;
        uint lowerPart;
        if (containsSpecialCharacter)
        {
            split = input.Split(foundSpecialCharacter);

            upperPart = characterValue / NC.D100;

            lowerPart = split[1].Length > 0
                ? this.GetTensPart(split[1])
                : 0U;
        }
        else if (split.Length == 2)
        {
            upperPart = this.GetTensPart(split[0]);

            lowerPart = split[1].Length > 0
                ? this.GetTensPart(split[1])
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = this.GetTensPart(split[0]);
        }

        var result = (upperPart * NC.D100) + lowerPart;

        return result;
    }

    private uint GetTensPart(string input)
    {
        var split = input.Split(_numeralCharacters.C10);

        if (split.Length > 2)
        {
            throw new InvalidInputException("Input is not valid");
        }

        var containsSpecialCharacter = false;
        var foundSpecialCharacter = ' ';
        var characterValue = 0U;
        ContainsSpecialCharacter(input, C10A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C20A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C20B, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C30A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);
        ContainsSpecialCharacter(input, C40A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);

        uint upperPart;
        uint lowerPart;
        if (containsSpecialCharacter)
        {
            split = input.Split(foundSpecialCharacter);

            if (string.IsNullOrEmpty(split[1]))
            {
                throw new InvalidInputException("Input is not valid");
            }

            upperPart = characterValue / NC.D10;

            lowerPart = this.GetTensPart(split[1]);
        }
        else if (split.Length == 2)
        {
            upperPart = split[0].Length > 0
                ? this.GetOnesPart(split[0])
                : 1U;

            lowerPart = split[1].Length > 0
                ? this.GetOnesPart(split[1])
                : 0U;
        }
        else
        {
            upperPart = 0;

            lowerPart = this.GetOnesPart(split[0]);
        }

        var result = (upperPart * NC.D10) + lowerPart;

        return result;
    }

    private uint GetOnesPart(string input)
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
            result = (uint)Array.IndexOf(_numeralCharacters.SingleDigits, character);
        }

        return result;
    }

    private static void ContainsSpecialCharacter(string input
        , char specialCharacterToLookFor
        , ref bool alreadyContainsSpecialCharacter
        , ref string[] split
        , ref char foundSpecialCharacter
        , ref uint characterValue)
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