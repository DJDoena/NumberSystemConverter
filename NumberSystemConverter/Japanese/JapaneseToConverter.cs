using DoenaSoft.NumberSystemConverter.EastAsia;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.EastAsiaNumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Japanese;

internal sealed class JapaneseToConverter(IEastAsia10p4NumeralCharacters numeralCharacters)
    : EastAsiaTo10p4ConverterBase(numeralCharacters)
{
    private static readonly Dictionary<char, ulong> _alternates = new()
    {
        { JapaneseCommonCharacterConstants.CircleZero, 0 },
        { JapaneseCommonCharacterConstants.TraditionalMan, 1_0000 },
    };

    protected override (bool containsSpecialCharacter, char foundSpecialCharacterout, ulong characterValue) ContainsSpecialCharacter(string input
        , ulong factor
        , string[] split)
    {
        var containsSpecialCharacter = false;
        var foundSpecialCharacter = '\0';
        var characterValue = 0UL;

        switch (factor)
        {
            case NC.D1_0000:
                {
                    this.ContainsSpecialCharacter(input, JapaneseCommonCharacterConstants.TraditionalMan, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);

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
        => [JapaneseCommonCharacterConstants.CircleZero];

    protected override bool TryGetAlternateCharacter(char character, out ulong value)
        => _alternates.TryGetValue(character, out value);
}