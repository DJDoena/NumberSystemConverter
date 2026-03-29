namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Character constants for Common Simplified Chinese number system.
/// Primary characters are always used for output (<see cref="INumberSystemConverter.FromULong"/>).
/// Both primary and alternate characters are accepted for input (<see cref="INumberSystemConverter.ToULong"/>).
/// Uses simplified Chinese characters following PRC standards.
/// </summary>
public static class ChineseCommonSimplifiedCharacterConstants
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
    /// Primary unit for 1,0000 (万, wàn) - ten thousand in Myriad system. Simplified form.
    /// <para>Value: 10000</para>
    /// <para>Unicode: U+4E07</para>
    /// </summary>
    public const char Wan = '万';

    /// <summary>
    /// Primary unit for 1,0000,0000 (亿, yì) - hundred million in Myriad system. Simplified form.
    /// <para>Value: 10000,0000</para>
    /// <para>Unicode: U+4EBF</para>
    /// </summary>
    public const char Yi = '亿';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000 (兆, zhào) - trillion in Myriad system.
    /// <para>Value: 10000,0000,0000</para>
    /// <para>Unicode: U+5146</para>
    /// </summary>
    public const char Zhao = '兆';

    /// <summary>
    /// Primary unit for 1,0000,0000,0000,0000 (京, jīng) - ten quadrillion in Myriad system.
    /// <para>Value: 10000,0000,0000,0000</para>
    /// <para>Unicode: U+4EAC</para>
    /// </summary>
    public const char Jing = '京';

    #endregion

    #region Alternate Characters - Zero

    /// <summary>
    /// Circle zero - common in modern Chinese texts.
    /// <para>Value: 0</para>
    /// <para>Source: Common in East Asian texts including Chinese.</para>
    /// <para>Unicode: U+3007</para>
    /// <para>Alternate for: 零</para>
    /// </summary>
    public const char CircleZero = '〇';

    /// <summary>
    /// "Empty" - colloquial way to say zero, especially in phone numbers.
    /// <para>Value: 0</para>
    /// <para>Source: Colloquial Chinese usage.</para>
    /// <para>Unicode: U+7A7A</para>
    /// <para>Alternate for: 零</para>
    /// </summary>
    public const char Kong = '空';

    /// <summary>
    /// "Hole" - slang for zero, used in spoken Chinese.
    /// <para>Value: 0</para>
    /// <para>Source: Spoken Chinese slang.</para>
    /// <para>Unicode: U+6D1E</para>
    /// <para>Alternate for: 零</para>
    /// </summary>
    public const char Dong = '洞';

    #endregion

    #region Alternate Characters - Digits

    /// <summary>
    /// Spoken alternate for 1 (幺, yāo) - used in phone numbers and military contexts.
    /// <para>Value: 1</para>
    /// <para>Source: Spoken Chinese, phone number pronunciation.</para>
    /// <para>Unicode: U+5E7A</para>
    /// <para>Alternate for: 一</para>
    /// </summary>
    public const char Yao = '幺';

    /// <summary>
    /// Regional/classical alternate for 1 (蜀, shǔ).
    /// <para>Value: 1</para>
    /// <para>Source: Regional dialect and classical texts.</para>
    /// <para>Unicode: U+8700</para>
    /// <para>Alternate for: 一</para>
    /// </summary>
    public const char Shu = '蜀';

    /// <summary>
    /// Simplified "two" (两, liǎng) - common measure word usage.
    /// <para>Value: 2</para>
    /// <para>Source: Common measure word in Chinese.</para>
    /// <para>Unicode: U+4E24</para>
    /// <para>Alternate for: 二</para>
    /// </summary>
    public const char LiangSimplified = '两';

    /// <summary>
    /// Traditional "two" (兩, liǎng) - common measure word usage.
    /// <para>Value: 2</para>
    /// <para>Source: Common measure word in Chinese.</para>
    /// <para>Unicode: U+5169</para>
    /// <para>Alternate for: 二</para>
    /// </summary>
    public const char LiangTraditional = '兩';

    /// <summary>
    /// Simplified colloquial "two items/people" (俩, liǎ).
    /// <para>Value: 2</para>
    /// <para>Source: Colloquial Chinese.</para>
    /// <para>Unicode: U+4FE9</para>
    /// <para>Alternate for: 二</para>
    /// </summary>
    public const char LiaSimplified = '俩';

    /// <summary>
    /// Traditional colloquial "two items/people" (倆, liǎ).
    /// <para>Value: 2</para>
    /// <para>Source: Colloquial Chinese.</para>
    /// <para>Unicode: U+5006</para>
    /// <para>Alternate for: 二</para>
    /// </summary>
    public const char LiaTraditional = '倆';

    /// <summary>
    /// Colloquial "three" (仨, sā) - especially for people/items.
    /// <para>Value: 3</para>
    /// <para>Source: Colloquial Chinese.</para>
    /// <para>Unicode: U+4EE8</para>
    /// <para>Alternate for: 三</para>
    /// </summary>
    public const char Sa = '仨';

    /// <summary>
    /// Spoken alternate for 7 (拐, guǎi) - used in phone numbers (sounds like "turn").
    /// <para>Value: 7</para>
    /// <para>Source: Phone number pronunciation to avoid confusion.</para>
    /// <para>Unicode: U+62D0</para>
    /// <para>Alternate for: 七</para>
    /// </summary>
    public const char Guai = '拐';

    /// <summary>
    /// Spoken alternate for 9 (勾, gōu) - used in phone numbers to avoid confusion.
    /// <para>Value: 9</para>
    /// <para>Source: Phone number pronunciation.</para>
    /// <para>Unicode: U+52FE</para>
    /// <para>Alternate for: 九</para>
    /// </summary>
    public const char Gou = '勾';

    #endregion

    #region Alternate Characters - Units

    /// <summary>
    /// Colloquial/dialectal alternate for 10 (呀, ya).
    /// <para>Value: 10</para>
    /// <para>Source: Colloquial/dialectal Chinese.</para>
    /// <para>Unicode: U+5440</para>
    /// <para>Alternate for: 十</para>
    /// </summary>
    public const char Ya = '呀';

    /// <summary>
    /// Colloquial "twenty" (念, niàn).
    /// <para>Value: 20</para>
    /// <para>Source: Colloquial pronunciation.</para>
    /// <para>Unicode: U+5FF5</para>
    /// <para>Alternate for: 二十</para>
    /// </summary>
    public const char Nian = '念';

    /// <summary>
    /// Classical shorthand for 20 (廿, niàn).
    /// <para>Value: 20</para>
    /// <para>Source: Classical Chinese shorthand.</para>
    /// <para>Unicode: U+5EFF</para>
    /// <para>Alternate for: 二十</para>
    /// </summary>
    public const char NianClassical = '廿';

    /// <summary>
    /// Classical shorthand for 30 (卅, sà).
    /// <para>Value: 30</para>
    /// <para>Source: Classical Chinese shorthand.</para>
    /// <para>Unicode: U+5345</para>
    /// <para>Alternate for: 三十</para>
    /// </summary>
    public const char Sa30 = '卅';

    /// <summary>
    /// Classical shorthand for 40 (卌, xì).
    /// <para>Value: 40</para>
    /// <para>Source: Classical Chinese shorthand.</para>
    /// <para>Unicode: U+534C</para>
    /// <para>Alternate for: 四十</para>
    /// </summary>
    public const char Xi = '卌';

    /// <summary>
    /// Classical character for 200 (皕, bì).
    /// <para>Value: 200</para>
    /// <para>Source: Classical Chinese.</para>
    /// <para>Unicode: U+7695</para>
    /// <para>Alternate for: 二百</para>
    /// </summary>
    public const char Bi = '皕';

    #endregion

    #region Alternate Characters - Large Units

    /// <summary>
    /// Simplified variant for 1,0000,0000,0000,0000 (经, jīng).
    /// <para>Value: 10000,0000,0000,0000</para>
    /// <para>Source: Historical/regional variant per Wikipedia.</para>
    /// <para>Unicode: U+7ECF</para>
    /// <para>Alternate for: 京</para>
    /// </summary>
    public const char JingSimplified = '经';

    /// <summary>
    /// Traditional variant for 1,0000,0000,0000,0000 (經, jīng).
    /// <para>Value: 10000,0000,0000,0000</para>
    /// <para>Source: Historical/regional variant per Wikipedia.</para>
    /// <para>Unicode: U+7D93</para>
    /// <para>Alternate for: 京</para>
    /// </summary>
    public const char JingTraditional = '經';

    #endregion
}
