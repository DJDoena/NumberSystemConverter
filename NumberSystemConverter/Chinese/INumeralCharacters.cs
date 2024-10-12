namespace DoenaSoft.NumberSystemConverter.Chinese;

public interface INumeralCharacters
{
    char[] SingleDigits { get; }

    /// <summary>
    /// 十
    /// </summary>
    char C10 { get; }

    /// <summary>
    /// 百
    /// </summary>
    char C100 { get; }

    /// <summary>
    /// 千
    /// </summary>
    char C1000 { get; }

    /// <summary>
    /// 万
    /// </summary>
    char C1_0000 { get; }

    /// <summary>
    /// 亿
    /// </summary>
    char C1_0000_0000 { get; }

    /// <summary>
    /// 兆
    /// </summary>
    char C1_0000_0000_0000 { get; }

    /// <summary>
    /// 京
    /// </summary>
    char C1_0000_0000_0000_0000 { get; }

    /// <summary>
    /// 垓
    /// </summary>
    char C1_0000_0000_0000_0000_0000 { get; }
}