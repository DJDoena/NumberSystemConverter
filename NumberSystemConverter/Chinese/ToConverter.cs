using DoenaSoft.NumberSystemConverter.EastAsia;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class ToConverter(I10p4NumeralCharacters numeralCharacters)
    : To10p4ConverterBase(numeralCharacters)
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

    private static readonly Dictionary<char, ulong> _alternates = new()
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

    protected override IEnumerable<char> GetAlternates()
        => _alternates.Keys;

    protected override (bool containsSpecialCharacter, char foundSpecialCharacterout, ulong characterValue) ContainsSpecialCharacter(string input
        , ulong factor
        , string[] split)
    {
        var containsSpecialCharacter = false;
        var foundSpecialCharacter = '\0';
        var characterValue = 0UL;

        switch (factor)
        {
            case NC.D100:
                {
                    this.ContainsSpecialCharacter(input, C200A, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);

                    break;
                }
            case NC.D10:
                {
                    this.ContainsSpecialCharacter(input, C10A, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, C20A, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, C20B, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, C30A, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, C40A, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);

                    break;
                }

        }

        return (containsSpecialCharacter, foundSpecialCharacter, characterValue);
    }

    protected override char[] GetAlternateZeroCharacters()
        => [C0A, C0B, C0C];

    protected override bool TryGetAlternateCharacter(char character, out ulong value)
        => _alternates.TryGetValue(character, out value);
}