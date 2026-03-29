namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Character constants for Financial Traditional Chinese number system.
/// Primary characters are always used for output (<see cref="INumberSystemConverter.FromULong"/>).
/// Both primary and alternate characters are accepted for input (<see cref="INumberSystemConverter.ToULong"/>).
/// Uses traditional Chinese financial characters to prevent alteration in legal/banking documents.
/// </summary>
public static class ChineseFinancialTraditionalCharacterConstants
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
    /// Primary financial digit 2 (貳, èr) - traditional form.
    /// <para>Value: 2</para>
    /// <para>Unicode: U+8CB3</para>
    /// </summary>
    public const char Two = '貳';

    /// <summary>
    /// Primary financial digit 3 (參, sān) - traditional form.
    /// <para>Value: 3</para>
    /// <para>Unicode: U+53C3</para>
    /// </summary>
    public const char Three = '參';

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
    /// Primary financial digit 6 (陸, liù) - traditional form.
    /// <para>Value: 6</para>
    /// <para>Unicode: U+9678</para>
    /// </summary>
    public const char Six = '陸';

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
    /// Primary unit for 1,0000 (萬, wàn) - ten thousand in Myriad system. Traditional form.
    /// <para>Value: 10000</para>
    /// <para>Unicode: U+842C</para>
    /// </summary>
    public const char Wan = '萬';

    /// <summary>
    /// Primary unit for 1,0000,0000 (億, yì) - hundred million in Myriad system.
    /// <para>Value: 10000,0000</para>
    /// <para>Unicode: U+5104</para>
    /// </summary>
    public const char Yi = '億';

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
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.CircleZero"/>
    /// </summary>
    public const char CircleZero = ChineseCommonTraditionalCharacterConstants.CircleZero;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Kong"/>
    /// </summary>
    public const char Kong = ChineseCommonTraditionalCharacterConstants.Kong;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Dong"/>
    /// </summary>
    public const char Dong = ChineseCommonTraditionalCharacterConstants.Dong;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Yao"/>
    /// </summary>
    public const char Yao = ChineseCommonTraditionalCharacterConstants.Yao;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Shu"/>
    /// </summary>
    public const char Shu = ChineseCommonTraditionalCharacterConstants.Shu;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.LiangSimplified"/>
    /// </summary>
    public const char LiangSimplified = ChineseCommonTraditionalCharacterConstants.LiangSimplified;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.LiangTraditional"/>
    /// </summary>
    public const char LiangTraditional = ChineseCommonTraditionalCharacterConstants.LiangTraditional;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.LiaSimplified"/>
    /// </summary>
    public const char LiaSimplified = ChineseCommonTraditionalCharacterConstants.LiaSimplified;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.LiaTraditional"/>
    /// </summary>
    public const char LiaTraditional = ChineseCommonTraditionalCharacterConstants.LiaTraditional;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Sa"/>
    /// </summary>
    public const char Sa = ChineseCommonTraditionalCharacterConstants.Sa;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Guai"/>
    /// </summary>
    public const char Guai = ChineseCommonTraditionalCharacterConstants.Guai;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Gou"/>
    /// </summary>
    public const char Gou = ChineseCommonTraditionalCharacterConstants.Gou;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Ya"/>
    /// </summary>
    public const char Ya = ChineseCommonTraditionalCharacterConstants.Ya;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Nian"/>
    /// </summary>
    public const char Nian = ChineseCommonTraditionalCharacterConstants.Nian;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.NianClassical"/>
    /// </summary>
    public const char NianClassical = ChineseCommonTraditionalCharacterConstants.NianClassical;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Sa30"/>
    /// </summary>
    public const char Sa30 = ChineseCommonTraditionalCharacterConstants.Sa30;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Xi"/>
    /// </summary>
    public const char Xi = ChineseCommonTraditionalCharacterConstants.Xi;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.Bi"/>
    /// </summary>
    public const char Bi = ChineseCommonTraditionalCharacterConstants.Bi;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.JingSimplified"/>
    /// </summary>
    public const char JingSimplified = ChineseCommonTraditionalCharacterConstants.JingSimplified;
    /// <summary>
    /// Alias for <see cref="ChineseCommonTraditionalCharacterConstants.JingTraditional"/>
    /// </summary>
    public const char JingTraditional = ChineseCommonTraditionalCharacterConstants.JingTraditional;

    #endregion
}
