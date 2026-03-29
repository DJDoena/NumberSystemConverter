namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Character set for Korean Hanja number system.
/// Provides Chinese character digits with small units.
/// </summary>
public sealed class KoreanHanjaNumeralCharacters : KoreanNumeralCharacterBase
{
    /// <inheritdoc/>
    public override char[] SingleDigits
        =>
        [
            KoreanHanjaCharacterConstants.Zero,
            KoreanHanjaCharacterConstants.One,
            KoreanHanjaCharacterConstants.Two,
            KoreanHanjaCharacterConstants.Three,
            KoreanHanjaCharacterConstants.Four,
            KoreanHanjaCharacterConstants.Five,
            KoreanHanjaCharacterConstants.Six,
            KoreanHanjaCharacterConstants.Seven,
            KoreanHanjaCharacterConstants.Eight,
            KoreanHanjaCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public override char C10
        => KoreanHanjaCharacterConstants.Ten;

    /// <inheritdoc/>
    public override char C100
        => KoreanHanjaCharacterConstants.Hundred;

    /// <inheritdoc/>
    public override char C1000
        => KoreanHanjaCharacterConstants.Thousand;
}
