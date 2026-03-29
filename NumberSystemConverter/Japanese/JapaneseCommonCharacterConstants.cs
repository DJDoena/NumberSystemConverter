namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Character constants for the Common Japanese number system.
/// Primary characters are always used for output (<see cref="INumberSystemConverter.FromULong"/>).
/// Both primary and alternate characters are accepted for input (<see cref="INumberSystemConverter.ToULong"/>).
/// </summary>
public static class JapaneseCommonCharacterConstants
{
    #region Primary Characters

    /// <summary>
    /// Primary digit 0.
    /// <para>Value: 0</para>
    /// <para>Unicode: U+96F6</para>
    /// </summary>
    public const char Zero = '零';

    /// <summary>
    /// Primary digit 1.
    /// <para>Value: 1</para>
    /// <para>Unicode: U+4E00</para>
    /// </summary>
    public const char One = '一';

    /// <summary>
    /// Primary digit 2.
    /// <para>Value: 2</para>
    /// <para>Unicode: U+4E8C</para>
    /// </summary>
    public const char Two = '二';

    /// <summary>
    /// Primary digit 3.
    /// <para>Value: 3</para>
    /// <para>Unicode: U+4E09</para>
    /// </summary>
    public const char Three = '三';

    /// <summary>
    /// Primary digit 4.
    /// <para>Value: 4</para>
    /// <para>Unicode: U+56DB</para>
    /// </summary>
    public const char Four = '四';

    /// <summary>
    /// Primary digit 5.
    /// <para>Value: 5</para>
    /// <para>Unicode: U+4E94</para>
    /// </summary>
    public const char Five = '五';

    /// <summary>
    /// Primary digit 6.
    /// <para>Value: 6</para>
    /// <para>Unicode: U+516D</para>
    /// </summary>
    public const char Six = '六';

    /// <summary>
    /// Primary digit 7.
    /// <para>Value: 7</para>
    /// <para>Unicode: U+4E03</para>
    /// </summary>
    public const char Seven = '七';

    /// <summary>
    /// Primary digit 8.
    /// <para>Value: 8</para>
    /// <para>Unicode: U+516B</para>
    /// </summary>
    public const char Eight = '八';

    /// <summary>
    /// Primary digit 9.
    /// <para>Value: 9</para>
    /// <para>Unicode: U+4E5D</para>
    /// </summary>
    public const char Nine = '九';

    /// <summary>
    /// Primary unit for 10.
    /// <para>Value: 10</para>
    /// <para>Unicode: U+5341</para>
    /// </summary>
    public const char Ten = '十';

    /// <summary>
    /// Primary unit for 100.
    /// <para>Value: 100</para>
    /// <para>Unicode: U+767E</para>
    /// </summary>
    public const char Hundred = '百';

    /// <summary>
    /// Primary unit for 1,000.
    /// <para>Value: 1000</para>
    /// <para>Unicode: U+5343</para>
    /// </summary>
    public const char Thousand = '千';

    /// <summary>
    /// Primary unit for 1,0000 (ten thousand). Modern simplified form.
    /// <para>Value: 10000</para>
    /// <para>Unicode: U+4E07</para>
    /// </summary>
    public const char Man = '万';

    /// <summary>
    /// Primary unit for 1,0000,0000 (hundred million).
    /// <para>Value: 10000,0000</para>
    /// <para>Unicode: U+5104</para>
    /// </summary>
    public const char Oku = '億';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000 (trillion).
    /// <para>Value: 10000,0000,0000</para>
    /// <para>Unicode: U+5146</para>
    /// </summary>
    public const char Chou = '兆';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000,0000 (ten quadrillion).
    /// <para>Value: 10000,0000,0000,0000</para>
    /// <para>Unicode: U+4EAC</para>
    /// </summary>
    public const char Kei = '京';

    #endregion

    #region Alternate Characters

    /// <summary>
    /// Circle zero - widely used in Japanese texts alongside 零.
    /// <para>Value: 0</para>
    /// <para>Source: Common in East Asian texts including Japanese.</para>
    /// <para>Unicode: U+3007</para>
    /// <para>Alternate for: 零 (primary zero)</para>
    /// </summary>
    public const char CircleZero = '〇';

    /// <summary>
    /// Traditional form for 万 (man, ten thousand).
    /// Still seen in formal documents and classical texts.
    /// <para>Value: 10000</para>
    /// <para>Source: Traditional Japanese writing - 萬 is the traditional form, 万 is the modern simplified form adopted after WWII.</para>
    /// <para>Unicode: U+842C</para>
    /// <para>Alternate for: 万 (primary 1,0000)</para>
    /// </summary>
    public const char TraditionalMan = '萬';

    #endregion
}
