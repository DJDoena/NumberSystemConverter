using DoenaSoft.NumberSystemConverter.EastAsia;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.EastAsiaNumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Korean;

internal sealed class KoreanToConverter(IEastAsia10p4NumeralCharacters numeralCharacters)
    : EastAsiaTo10p4ConverterBase(numeralCharacters)
{
    private static readonly Dictionary<char, ulong> _alternates = new()
    {
        { KoreanHangulCharacterConstants.AlternateZero, 0 },
        { KoreanHanjaCharacterConstants.CircleZero, 0 },
        { KoreanFinancialCharacterConstants.AlternateThousand, 1000 },
        { KoreanHanjaCharacterConstants.ChineseSimplifiedMan, 1_0000 },
        { KoreanHanjaCharacterConstants.ChineseTraditionalMan, 1_0000 },
        { KoreanHanjaCharacterConstants.ChineseJo, 1_0000_0000_0000 },
        { KoreanHanjaCharacterConstants.ChineseGyeong, 1_0000_0000_0000_0000 },
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
            case NC.D1_0000_0000_0000_0000:
                {
                    this.ContainsSpecialCharacter(input, KoreanHanjaCharacterConstants.ChineseGyeong, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);

                    break;
                }
            case NC.D1_0000_0000_0000:
                {
                    this.ContainsSpecialCharacter(input, KoreanHanjaCharacterConstants.ChineseJo, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);

                    break;
                }
            case NC.D1_0000:
                {
                    this.ContainsSpecialCharacter(input, KoreanHanjaCharacterConstants.ChineseSimplifiedMan, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);
                    this.ContainsSpecialCharacter(input, KoreanHanjaCharacterConstants.ChineseTraditionalMan, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);

                    break;
                }
            case NC.D1000:
                {
                    this.ContainsSpecialCharacter(input, KoreanFinancialCharacterConstants.AlternateThousand, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);

                    if (string.IsNullOrEmpty(split[0]))
                    {
                        split[0] = _numeralCharacters.SingleDigits[1].ToString();
                    }

                    break;
                }
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
        => [KoreanHangulCharacterConstants.AlternateZero, KoreanHanjaCharacterConstants.CircleZero];

    protected override bool TryGetAlternateCharacter(char character, out ulong value)
        => _alternates.TryGetValue(character, out value);
}
