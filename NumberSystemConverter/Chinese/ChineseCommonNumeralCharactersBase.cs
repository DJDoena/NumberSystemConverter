namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Base class for common (non-financial) Chinese numeral character sets.
/// Provides the standard digit and small unit characters (0-1,000).
/// </summary>
public abstract class ChineseCommonNumeralCharactersBase : ChineseNumeralCharactersBase
{
    /// <inheritdoc/>
    public sealed override char[] SingleDigits
        =>
        [
            ChineseCommonSimplifiedCharacterConstants.Zero,
            ChineseCommonSimplifiedCharacterConstants.One,
            ChineseCommonSimplifiedCharacterConstants.Two,
            ChineseCommonSimplifiedCharacterConstants.Three,
            ChineseCommonSimplifiedCharacterConstants.Four,
            ChineseCommonSimplifiedCharacterConstants.Five,
            ChineseCommonSimplifiedCharacterConstants.Six,
            ChineseCommonSimplifiedCharacterConstants.Seven,
            ChineseCommonSimplifiedCharacterConstants.Eight,
            ChineseCommonSimplifiedCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public sealed override char C10
        => ChineseCommonSimplifiedCharacterConstants.Ten;

    /// <inheritdoc/>
    public sealed override char C100
        => ChineseCommonSimplifiedCharacterConstants.Hundred;

    /// <inheritdoc/>
    public sealed override char C1000
        => ChineseCommonSimplifiedCharacterConstants.Thousand;
}