namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Character constants for Financial Simplified Chinese number system.
/// Primary characters are always used for output (<see cref="INumberSystemConverter.FromULong"/>).
/// Both primary and alternate characters are accepted for input (<see cref="INumberSystemConverter.ToULong"/>).
/// Uses simplified Chinese financial characters to prevent alteration in legal/banking documents.
/// </summary>
public static class ChineseFinancialSimplifiedCharacterConstants
{
    #region Primary Characters

    /// <summary>
    /// Primary digit 0 (零, líng) - regular zero used in financial documents.
    /// <para>Value: 0</para>
    /// <para>Unicode: U+96F6</para>
    /// </summary>
    public const char Zero = '零';

    /// <summary>
    /// Primary financial digit 1 (壹, yī).
    /// <para>Value: 1</para>
    /// <para>Unicode: U+58F9</para>
    /// </summary>
    public const char One = '壹';

    /// <summary>
    /// Primary financial digit 2 (贰, èr) - simplified form.
    /// <para>Value: 2</para>
    /// <para>Unicode: U+8D30</para>
    /// </summary>
    public const char Two = '贰';

    /// <summary>
    /// Primary financial digit 3 (叁, sān) - simplified form.
    /// <para>Value: 3</para>
    /// <para>Unicode: U+53C1</para>
    /// </summary>
    public const char Three = '叁';

    /// <summary>
    /// Primary financial digit 4 (肆, sì).
    /// <para>Value: 4</para>
    /// <para>Unicode: U+8086</para>
    /// </summary>
    public const char Four = '肆';

    /// <summary>
    /// Primary financial digit 5 (伍, wǔ).
    /// <para>Value: 5</para>
    /// <para>Unicode: U+4F0D</para>
    /// </summary>
    public const char Five = '伍';

    /// <summary>
    /// Primary financial digit 6 (陆, liù) - simplified form.
    /// <para>Value: 6</para>
    /// <para>Unicode: U+9646</para>
    /// </summary>
    public const char Six = '陆';

    /// <summary>
    /// Primary financial digit 7 (柒, qī).
    /// <para>Value: 7</para>
    /// <para>Unicode: U+67D2</para>
    /// </summary>
    public const char Seven = '柒';

    /// <summary>
    /// Primary financial digit 8 (捌, bā).
    /// <para>Value: 8</para>
    /// <para>Unicode: U+634C</para>
    /// </summary>
    public const char Eight = '捌';

    /// <summary>
    /// Primary financial digit 9 (玖, jiǔ).
    /// <para>Value: 9</para>
    /// <para>Unicode: U+7396</para>
    /// </summary>
    public const char Nine = '玖';

    /// <summary>
    /// Primary financial unit for 10 (拾, shí).
    /// <para>Value: 10</para>
    /// <para>Unicode: U+62FE</para>
    /// </summary>
    public const char Ten = '拾';

    /// <summary>
    /// Primary financial unit for 100 (佰, bǎi).
    /// <para>Value: 100</para>
    /// <para>Unicode: U+4F70</para>
    /// </summary>
    public const char Hundred = '佰';

    /// <summary>
    /// Primary financial unit for 1,000 (仟, qiān).
    /// <para>Value: 1000</para>
    /// <para>Unicode: U+4EDF</para>
    /// </summary>
    public const char Thousand = '仟';

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

    #region Alternate Characters - Shared with Common

    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.CircleZero"/>
    /// </summary>
    public const char CircleZero = ChineseCommonSimplifiedCharacterConstants.CircleZero;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Kong"/>
    /// </summary>
    public const char Kong = ChineseCommonSimplifiedCharacterConstants.Kong;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Dong"/>
    /// </summary>
    public const char Dong = ChineseCommonSimplifiedCharacterConstants.Dong;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Yao"/>
    /// </summary>
    public const char Yao = ChineseCommonSimplifiedCharacterConstants.Yao;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Shu"/>
    /// </summary>
    public const char Shu = ChineseCommonSimplifiedCharacterConstants.Shu;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.LiangSimplified"/>
    /// </summary>
    public const char LiangSimplified = ChineseCommonSimplifiedCharacterConstants.LiangSimplified;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.LiangTraditional"/>
    /// </summary>
    public const char LiangTraditional = ChineseCommonSimplifiedCharacterConstants.LiangTraditional;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.LiaSimplified"/>
    /// </summary>
    public const char LiaSimplified = ChineseCommonSimplifiedCharacterConstants.LiaSimplified;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.LiaTraditional"/>
    /// </summary>
    public const char LiaTraditional = ChineseCommonSimplifiedCharacterConstants.LiaTraditional;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Sa"/>
    /// </summary>
    public const char Sa = ChineseCommonSimplifiedCharacterConstants.Sa;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Guai"/>
    /// </summary>
    public const char Guai = ChineseCommonSimplifiedCharacterConstants.Guai;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Gou"/>
    /// </summary>
    public const char Gou = ChineseCommonSimplifiedCharacterConstants.Gou;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Ya"/>
    /// </summary>
    public const char Ya = ChineseCommonSimplifiedCharacterConstants.Ya;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Nian"/>
    /// </summary>
    public const char Nian = ChineseCommonSimplifiedCharacterConstants.Nian;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.NianClassical"/>
    /// </summary>
    public const char NianClassical = ChineseCommonSimplifiedCharacterConstants.NianClassical;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Sa30"/>
    /// </summary>
    public const char Sa30 = ChineseCommonSimplifiedCharacterConstants.Sa30;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Xi"/>
    /// </summary>
    public const char Xi = ChineseCommonSimplifiedCharacterConstants.Xi;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.Bi"/>
    /// </summary>
    public const char Bi = ChineseCommonSimplifiedCharacterConstants.Bi;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.JingSimplified"/>
    /// </summary>
    public const char JingSimplified = ChineseCommonSimplifiedCharacterConstants.JingSimplified;
    /// <summary>
    /// Alias for <see cref="ChineseCommonSimplifiedCharacterConstants.JingTraditional"/>
    /// </summary>
    public const char JingTraditional = ChineseCommonSimplifiedCharacterConstants.JingTraditional;

    #endregion
}
