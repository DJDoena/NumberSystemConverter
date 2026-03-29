namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Character constants for the Korean Hanja number system (regular Chinese characters with Korean large units).
/// Primary characters are always used for output (<see cref="INumberSystemConverter.FromULong"/>).
/// Both primary and alternate characters are accepted for input (<see cref="INumberSystemConverter.ToULong"/>).
/// Note: Uses Chinese characters for digits and small units (0-1,000), Korean Hangul for large units (1,0000+).
/// </summary>
public static class KoreanHanjaCharacterConstants
{
    #region Primary Characters

    /// <summary>
    /// Primary digit 0 (零, líng).
    /// <para>Value: 0</para>
    /// <para>Unicode: U+96F6</para>
    /// </summary>
    public const char Zero = '零';

    /// <summary>
    /// Primary digit 1 (一, yī).
    /// <para>Value: 1</para>
    /// <para>Unicode: U+4E00</para>
    /// </summary>
    public const char One = '一';

    /// <summary>
    /// Primary digit 2 (二, èr).
    /// <para>Value: 2</para>
    /// <para>Unicode: U+4E8C</para>
    /// </summary>
    public const char Two = '二';

    /// <summary>
    /// Primary digit 3 (三, sān).
    /// <para>Value: 3</para>
    /// <para>Unicode: U+4E09</para>
    /// </summary>
    public const char Three = '三';

    /// <summary>
    /// Primary digit 4 (四, sì).
    /// <para>Value: 4</para>
    /// <para>Unicode: U+56DB</para>
    /// </summary>
    public const char Four = '四';

    /// <summary>
    /// Primary digit 5 (五, wǔ).
    /// <para>Value: 5</para>
    /// <para>Unicode: U+4E94</para>
    /// </summary>
    public const char Five = '五';

    /// <summary>
    /// Primary digit 6 (六, liù).
    /// <para>Value: 6</para>
    /// <para>Unicode: U+516D</para>
    /// </summary>
    public const char Six = '六';

    /// <summary>
    /// Primary digit 7 (七, qī).
    /// <para>Value: 7</para>
    /// <para>Unicode: U+4E03</para>
    /// </summary>
    public const char Seven = '七';

    /// <summary>
    /// Primary digit 8 (八, bā).
    /// <para>Value: 8</para>
    /// <para>Unicode: U+516B</para>
    /// </summary>
    public const char Eight = '八';

    /// <summary>
    /// Primary digit 9 (九, jiǔ).
    /// <para>Value: 9</para>
    /// <para>Unicode: U+4E5D</para>
    /// </summary>
    public const char Nine = '九';

    /// <summary>
    /// Primary unit for 10 (十, shí).
    /// <para>Value: 10</para>
    /// <para>Unicode: U+5341</para>
    /// </summary>
    public const char Ten = '十';

    /// <summary>
    /// Primary unit for 100 (百, bǎi).
    /// <para>Value: 100</para>
    /// <para>Unicode: U+767E</para>
    /// </summary>
    public const char Hundred = '百';

    /// <summary>
    /// Primary unit for 1,000 (千, qiān).
    /// <para>Value: 1000</para>
    /// <para>Unicode: U+5343</para>
    /// </summary>
    public const char Thousand = '千';

    /// <summary>
    /// Primary unit for 1,0000 (만, man) - ten thousand in Myriad system. Uses Korean Hangul.
    /// <para>Value: 10000</para>
    /// <para>Unicode: U+B9CC</para>
    /// </summary>
    public const char Man = '만';

    /// <summary>
    /// Primary unit for 1,0000,0000 (억, eok) - hundred million in Myriad system. Uses Korean Hangul.
    /// <para>Value: 10000,0000</para>
    /// <para>Unicode: U+C5B5</para>
    /// </summary>
    public const char Eok = '억';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000 (조, jo) - trillion in Myriad system. Uses Korean Hangul.
    /// <para>Value: 10000,0000,0000</para>
    /// <para>Unicode: U+C870</para>
    /// </summary>
    public const char Jo = '조';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000,0000 (경, gyeong) - ten quadrillion in Myriad system. Uses Korean Hangul.
    /// <para>Value: 10000,0000,0000,0000</para>
    /// <para>Unicode: U+ACBD</para>
    /// </summary>
    public const char Gyeong = '경';

    #endregion

    #region Alternate Characters

    /// <summary>
    /// Circle zero - common in East Asian texts.
    /// <para>Value: 0</para>
    /// <para>Source: Common in East Asian texts including Hanja notation.</para>
    /// <para>Unicode: U+3007</para>
    /// <para>Alternate for: 零 (primary zero)</para>
    /// </summary>
    public const char CircleZero = '〇';

    /// <summary>
    /// Chinese simplified form for 1,0000 (万, wàn).
    /// <para>Value: 10000</para>
    /// <para>Source: Chinese-Korean cross-border documents and historical texts.</para>
    /// <para>Unicode: U+4E07</para>
    /// <para>Alternate for: 만 (primary 1,0000)</para>
    /// </summary>
    public const char ChineseSimplifiedMan = '万';

    /// <summary>
    /// Chinese traditional form for 1,0000 (萬, wàn).
    /// <para>Value: 10000</para>
    /// <para>Source: Chinese-Korean cross-border documents and historical texts.</para>
    /// <para>Unicode: U+842C</para>
    /// <para>Alternate for: 만 (primary 1,0000)</para>
    /// </summary>
    public const char ChineseTraditionalMan = '萬';

    /// <summary>
    /// Chinese character for 1,0000,0000,0000 (兆, zhào).
    /// <para>Value: 10000,0000,0000</para>
    /// <para>Source: Korean 조 is phonetic reading of Chinese character 兆.</para>
    /// <para>Unicode: U+5146</para>
    /// <para>Alternate for: 조 (primary trillion)</para>
    /// </summary>
    public const char ChineseJo = '兆';

    /// <summary>
    /// Chinese character for 1,0000,0000,0000,0000 (京, jīng).
    /// <para>Value: 10000,0000,0000,0000</para>
    /// <para>Source: Korean 경 is phonetic reading of Chinese character 京.</para>
    /// <para>Unicode: U+4EAC</para>
    /// <para>Alternate for: 경 (primary ten quadrillion)</para>
    /// </summary>
    public const char ChineseGyeong = '京';

    #endregion
}
