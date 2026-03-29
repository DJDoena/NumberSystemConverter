namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Converter for Korean Hangul number system (native Korean script).
/// Uses pure Korean characters: 영, 일, 이, 삼, etc.
/// </summary>
public sealed class KoreanHangulNumeralConverter : KoreanNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KoreanHangulNumeralConverter"/> class.
    /// </summary>
    public KoreanHangulNumeralConverter() : base(new KoreanHangulNumeralCharacters())
    {
    }
}
