namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class ToUIntNumericalConverter
{
    private static readonly Dictionary<char, ushort> _alternates;

    private readonly INumeralCharacters _numeralCharacters;

    static ToUIntNumericalConverter()
    {
        _alternates = new()
        {
            { '空', 0 },
            { '洞', 0 },
            { '幺', 1 },
            { '蜀', 1 },
            { '两', 2 },
            { '兩', 2 },
            { '俩', 2 },
            { '倆', 2 },
            { '仨', 3 },
            { '拐', 7 },
            { '勾', 9 },
            { '呀', 10 },
            { '念', 20 },
            { '廿', 20 },
            { '卅', 30 },
            { '卌', 40 },
            { '皕', 200 },
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

        throw new NotImplementedException();
    }
}