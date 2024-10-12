using DoenaSoft.NumberSystemConverter.EastAsia;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Japanese;

internal sealed class ToConverter(I10p4NumeralCharacters numeralCharacters)
    : To10p4ConverterBase(numeralCharacters)
{
    private const char J0A = '〇';

    private const char J10000A = '萬';

    private static readonly Dictionary<char, ulong> _alternates = new()
    {
        { J0A, 0 },
        { J10000A, 1_0000 },
    };

    protected override (bool containsSpecialCharacter, char foundSpecialCharacterout, ulong characterValue) ContainsSpecialCharacter(string input
        , ulong factor
        , ref string[] split)
    {
        var containsSpecialCharacter = false;
        var foundSpecialCharacter = '\0';
        var characterValue = 0UL;

        switch (factor)
        {
            case NC.D1_0000:
                {
                    this.ContainsSpecialCharacter(input, J10000A, ref containsSpecialCharacter, ref split, ref foundSpecialCharacter, ref characterValue);

                    break;
                }
            case NC.D1000:
            case NC.D100:
                {
                    if (string.IsNullOrEmpty(split[0]))
                    {
                        split[0] = _numeralCharacters.SingleDigits[1].ToString();
                    }

                    break;
                }
        }

        return (containsSpecialCharacter, foundSpecialCharacter, characterValue);
    }

    protected override IEnumerable<char> GetAlternates()
        => _alternates.Keys;

    protected override char[] GetAlternateZeroCharacters()
        => [J0A];

    protected override bool TryGetAlternateCharacter(char character, out ulong value)
        => _alternates.TryGetValue(character, out value);
}