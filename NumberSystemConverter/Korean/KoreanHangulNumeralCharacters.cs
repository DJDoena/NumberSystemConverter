namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Character set for Korean Hangul number system.
/// Provides native Korean script characters.
/// </summary>
public sealed class KoreanHangulNumeralCharacters : KoreanNumeralCharacterBase
{
    /// <inheritdoc/>
    public override char[] SingleDigits
        =>
        [
            KoreanHangulCharacterConstants.Zero,
            KoreanHangulCharacterConstants.One,
            KoreanHangulCharacterConstants.Two,
            KoreanHangulCharacterConstants.Three,
            KoreanHangulCharacterConstants.Four,
            KoreanHangulCharacterConstants.Five,
            KoreanHangulCharacterConstants.Six,
            KoreanHangulCharacterConstants.Seven,
            KoreanHangulCharacterConstants.Eight,
            KoreanHangulCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public override char C10
        => KoreanHangulCharacterConstants.Ten;

    /// <inheritdoc/>
    public override char C100
        => KoreanHangulCharacterConstants.Hundred;

    /// <inheritdoc/>
    public override char C1000
        => KoreanHangulCharacterConstants.Thousand;
}
