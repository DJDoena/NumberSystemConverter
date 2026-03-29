using DoenaSoft.NumberSystemConverter.EastAsia;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.EastAsiaNumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class ChineseToConverter(IEastAsia10p4NumeralCharacters numeralCharacters)
    : EastAsiaTo10p4ConverterBase(numeralCharacters)
{
    private static readonly Dictionary<char, ulong> _alternates = new()
    {
        { ChineseCommonSimplifiedCharacterConstants.CircleZero, 0 },
        { ChineseCommonSimplifiedCharacterConstants.Kong, 0 },
        { ChineseCommonSimplifiedCharacterConstants.Dong, 0 },
        { ChineseCommonSimplifiedCharacterConstants.Yao, 1 },
        { ChineseCommonSimplifiedCharacterConstants.Shu, 1 },
        { ChineseCommonSimplifiedCharacterConstants.LiangSimplified, 2 },
        { ChineseCommonSimplifiedCharacterConstants.LiangTraditional, 2 },
        { ChineseCommonSimplifiedCharacterConstants.LiaSimplified, 2 },
        { ChineseCommonSimplifiedCharacterConstants.LiaTraditional, 2 },
        { ChineseCommonSimplifiedCharacterConstants.Sa, 3 },
        { ChineseCommonSimplifiedCharacterConstants.Guai, 7 },
        { ChineseCommonSimplifiedCharacterConstants.Gou, 9 },
        { ChineseCommonSimplifiedCharacterConstants.Ya, 10 },
        { ChineseCommonSimplifiedCharacterConstants.Nian, 20 },
        { ChineseCommonSimplifiedCharacterConstants.NianClassical, 20 },
        { ChineseCommonSimplifiedCharacterConstants.Sa30, 30 },
        { ChineseCommonSimplifiedCharacterConstants.Xi, 40 },
        { ChineseCommonSimplifiedCharacterConstants.Bi, 200 },
        { ChineseCommonSimplifiedCharacterConstants.JingSimplified, 1_0000_0000_0000_0000 },
        { ChineseCommonSimplifiedCharacterConstants.JingTraditional, 1_0000_0000_0000_0000 },
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
            case NC.D1_0000_0000_0000_0000:
                {
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.JingSimplified, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.JingTraditional, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue, specialCharacterIsUnit: true);

                    break;
                }
            case NC.D100:
                {
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.Bi, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);

                    break;
                }
            case NC.D10:
                {
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.Ya, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.Nian, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.NianClassical, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.Sa30, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);
                    this.ContainsSpecialCharacter(input, ChineseCommonSimplifiedCharacterConstants.Xi, ref containsSpecialCharacter, split, ref foundSpecialCharacter, ref characterValue);

                    break;
                }

        }

        return (containsSpecialCharacter, foundSpecialCharacter, characterValue);
    }

    protected override char[] GetAlternateZeroCharacters()
        => [ChineseCommonSimplifiedCharacterConstants.CircleZero, ChineseCommonSimplifiedCharacterConstants.Kong, ChineseCommonSimplifiedCharacterConstants.Dong];

    protected override bool TryGetAlternateCharacter(char character, out ulong value)
        => _alternates.TryGetValue(character, out value);
}