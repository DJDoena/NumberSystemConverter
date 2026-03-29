namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Converter for Korean Hanja number system (regular Chinese characters with Korean large units).
/// Uses Chinese characters for digits (零, 一, 二, etc.) with Korean Hangul for large units (만, 억, 조, 경).
/// </summary>
public sealed class KoreanHanjaNumeralConverter : KoreanNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KoreanHanjaNumeralConverter"/> class.
    /// </summary>
    public KoreanHanjaNumeralConverter() : base(new KoreanHanjaNumeralCharacters())
    {
    }
}
