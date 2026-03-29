namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Character constants for the Financial Japanese number system.
/// Primary characters are always used for output (<see cref="INumberSystemConverter.FromULong"/>).
/// Both primary and alternate characters are accepted for input (<see cref="INumberSystemConverter.ToULong"/>).
/// Uses complex financial characters to prevent alteration in legal/banking documents.
/// </summary>
public static class JapaneseFinancialCharacterConstants
{
    #region Primary Characters

    /// <summary>
    /// Primary digit 0 (零).
    /// <para>Value: 0</para>
    /// <para>Unicode: U+96F6</para>
    /// </summary>
    public const char Zero = '零';

    /// <summary>
    /// Primary financial digit 1 (壱, ichi).
    /// <para>Value: 1</para>
    /// <para>Unicode: U+58F1</para>
    /// </summary>
    public const char One = '壱';

    /// <summary>
    /// Primary financial digit 2 (弐, ni).
    /// <para>Value: 2</para>
    /// <para>Unicode: U+5F10</para>
    /// </summary>
    public const char Two = '弐';

    /// <summary>
    /// Primary financial digit 3 (参, san).
    /// <para>Value: 3</para>
    /// <para>Unicode: U+53C2</para>
    /// </summary>
    public const char Three = '参';

    /// <summary>
    /// Primary digit 4 (四, shi/yon).
    /// <para>Value: 4</para>
    /// <para>Unicode: U+56DB</para>
    /// </summary>
    public const char Four = '四';

    /// <summary>
    /// Primary digit 5 (五, go).
    /// <para>Value: 5</para>
    /// <para>Unicode: U+4E94</para>
    /// </summary>
    public const char Five = '五';

    /// <summary>
    /// Primary digit 6 (六, roku).
    /// <para>Value: 6</para>
    /// <para>Unicode: U+516D</para>
    /// </summary>
    public const char Six = '六';

    /// <summary>
    /// Primary digit 7 (七, nana/shichi).
    /// <para>Value: 7</para>
    /// <para>Unicode: U+4E03</para>
    /// </summary>
    public const char Seven = '七';

    /// <summary>
    /// Primary digit 8 (八, hachi).
    /// <para>Value: 8</para>
    /// <para>Unicode: U+516B</para>
    /// </summary>
    public const char Eight = '八';

    /// <summary>
    /// Primary digit 9 (九, kyuu/ku).
    /// <para>Value: 9</para>
    /// <para>Unicode: U+4E5D</para>
    /// </summary>
    public const char Nine = '九';

    /// <summary>
    /// Primary financial unit for 10 (拾, juu).
    /// <para>Value: 10</para>
    /// <para>Unicode: U+62FE</para>
    /// </summary>
    public const char Ten = '拾';

    /// <summary>
    /// Primary unit for 100 (百, hyaku).
    /// <para>Value: 100</para>
    /// <para>Unicode: U+767E</para>
    /// </summary>
    public const char Hundred = '百';

    /// <summary>
    /// Primary unit for 1,000 (千, sen).
    /// <para>Value: 1000</para>
    /// <para>Unicode: U+5343</para>
    /// </summary>
    public const char Thousand = '千';

    /// <summary>
    /// Primary unit for 1,0000 (万, man) - ten thousand in Myriad system.
    /// <para>Value: 10000</para>
    /// <para>Unicode: U+4E07</para>
    /// </summary>
    public const char Man = '万';

    /// <summary>
    /// Primary unit for 1,0000,0000 (億, oku) - hundred million in Myriad system.
    /// <para>Value: 10000,0000</para>
    /// <para>Unicode: U+5104</para>
    /// </summary>
    public const char Oku = '億';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000 (兆, chou) - trillion in Myriad system.
    /// <para>Value: 10000,0000,0000</para>
    /// <para>Unicode: U+5146</para>
    /// </summary>
    public const char Chou = '兆';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000,0000 (京, kei) - ten quadrillion in Myriad system.
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
    /// Traditional form for 1,0000 (萬, man).
    /// Still seen in formal documents and classical texts.
    /// <para>Value: 10000</para>
    /// <para>Source: Traditional Japanese writing - 萬 is the traditional form, 万 is the modern simplified form adopted after WWII.</para>
    /// <para>Unicode: U+842C</para>
    /// <para>Alternate for: 万 (primary 1,0000)</para>
    /// </summary>
    public const char TraditionalMan = '萬';

    #endregion
}
