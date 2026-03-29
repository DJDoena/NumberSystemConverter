namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Character constants for the Korean Hangul number system (native Korean script).
/// Primary characters are always used for output (<see cref="INumberSystemConverter.FromULong"/>).
/// Both primary and alternate characters are accepted for input (<see cref="INumberSystemConverter.ToULong"/>).
/// </summary>
public static class KoreanHangulCharacterConstants
{
    #region Primary Characters

    /// <summary>
    /// Primary digit 0 (영, yeong).
    /// <para>Value: 0</para>
    /// <para>Unicode: U+C601</para>
    /// </summary>
    public const char Zero = '영';

    /// <summary>
    /// Primary digit 1 (일, il).
    /// <para>Value: 1</para>
    /// <para>Unicode: U+C77C</para>
    /// </summary>
    public const char One = '일';

    /// <summary>
    /// Primary digit 2 (이, i).
    /// <para>Value: 2</para>
    /// <para>Unicode: U+C774</para>
    /// </summary>
    public const char Two = '이';

    /// <summary>
    /// Primary digit 3 (삼, sam).
    /// <para>Value: 3</para>
    /// <para>Unicode: U+C0BC</para>
    /// </summary>
    public const char Three = '삼';

    /// <summary>
    /// Primary digit 4 (사, sa).
    /// <para>Value: 4</para>
    /// <para>Unicode: U+C0AC</para>
    /// </summary>
    public const char Four = '사';

    /// <summary>
    /// Primary digit 5 (오, o).
    /// <para>Value: 5</para>
    /// <para>Unicode: U+C624</para>
    /// </summary>
    public const char Five = '오';

    /// <summary>
    /// Primary digit 6 (육, yuk).
    /// <para>Value: 6</para>
    /// <para>Unicode: U+C721</para>
    /// </summary>
    public const char Six = '육';

    /// <summary>
    /// Primary digit 7 (칠, chil).
    /// <para>Value: 7</para>
    /// <para>Unicode: U+CE60</para>
    /// </summary>
    public const char Seven = '칠';

    /// <summary>
    /// Primary digit 8 (팔, pal).
    /// <para>Value: 8</para>
    /// <para>Unicode: U+D314</para>
    /// </summary>
    public const char Eight = '팔';

    /// <summary>
    /// Primary digit 9 (구, gu).
    /// <para>Value: 9</para>
    /// <para>Unicode: U+AD6C</para>
    /// </summary>
    public const char Nine = '구';

    /// <summary>
    /// Primary unit for 10 (십, sip).
    /// <para>Value: 10</para>
    /// <para>Unicode: U+C2ED</para>
    /// </summary>
    public const char Ten = '십';

    /// <summary>
    /// Primary unit for 100 (백, baek).
    /// <para>Value: 100</para>
    /// <para>Unicode: U+BC31</para>
    /// </summary>
    public const char Hundred = '백';

    /// <summary>
    /// Primary unit for 1,000 (천, cheon).
    /// <para>Value: 1000</para>
    /// <para>Unicode: U+CC9C</para>
    /// </summary>
    public const char Thousand = '천';

    /// <summary>
    /// Primary unit for 1,0000 (만, man) - ten thousand in Myriad system.
    /// <para>Value: 10000</para>
    /// <para>Unicode: U+B9CC</para>
    /// </summary>
    public const char Man = '만';

    /// <summary>
    /// Primary unit for 1,0000,0000 (억, eok) - hundred million in Myriad system.
    /// <para>Value: 10000,0000</para>
    /// <para>Unicode: U+C5B5</para>
    /// </summary>
    public const char Eok = '억';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000 (조, jo) - trillion in Myriad system.
    /// <para>Value: 10000,0000,0000</para>
    /// <para>Unicode: U+C870</para>
    /// </summary>
    public const char Jo = '조';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000,0000 (경, gyeong) - ten quadrillion in Myriad system.
    /// <para>Value: 10000,0000,0000,0000</para>
    /// <para>Unicode: U+ACBD</para>
    /// </summary>
    public const char Gyeong = '경';

    #endregion

    #region Alternate Characters

    /// <summary>
    /// Alternate pronunciation for 0 (공, gong).
    /// <para>Value: 0</para>
    /// <para>Source: Common Korean usage - alternate pronunciation for zero.</para>
    /// <para>Unicode: U+ACF5</para>
    /// <para>Alternate for: 영 (primary zero)</para>
    /// </summary>
    public const char AlternateZero = '공';

    #endregion
}
