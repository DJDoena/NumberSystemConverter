using DoenaSoft.NumberSystemConverter.Chinese;
using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Tests.Japanese;

[TestClass]
public sealed class JapaneseConverterTests
{
    [TestMethod]
    public void GetUIntInputNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(null!, ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']));

    [TestMethod]
    public void GetUIntInputEmpty()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(string.Empty, ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']));

    [TestMethod]
    public void GetUIntInputWhitespace()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(" ", ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']));

    [TestMethod]
    public void GetUIntCharactersNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt("0", null!));

    [TestMethod]
    public void GetUIntCharactersEmpty()
          => Assert.ThrowsExactly<ArgumentException>(() => ToUInt("0", []));

    [TestMethod]
    public void GetUIntInvalidCharacter()
        => Assert.ThrowsExactly<InvalidInputException>(() => ToUInt("A", ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']));

    [TestMethod]
    public void GetStringCharactersNull()
      => Assert.ThrowsExactly<ArgumentNullException>(() => FromUInt(0, null!));

    [TestMethod]
    public void GetStringCharactersEmpty()
        => Assert.ThrowsExactly<ArgumentException>(() => FromUInt(0, []));

    [TestMethod]
    public void NumeralCharactersNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => (new TestChineseConverter((IEastAsia10p4NumeralCharacters)null!)).ToULong(""));

    private static void ToUInt(string input
        , char[] validCharacters)
        => (new TestChineseConverter(validCharacters)).ToULong(input);

    private static void FromUInt(ulong input
        , char[] validCharacters)
        => (new TestChineseConverter(validCharacters)).FromULong(input);

    private sealed class TestChineseConverter : ChineseNumeralConverterBase
    {
        internal TestChineseConverter(IEastAsia10p4NumeralCharacters numeralCharacters)
            : base(numeralCharacters)
        {
        }

        internal TestChineseConverter(char[] singleDigits)
            : this(new TestNumeralCharacters(singleDigits))
        {
        }
    }

    private sealed class TestNumeralCharacters : IEastAsia10p4NumeralCharacters
    {
        public char[] SingleDigits { get; }

        public char C10
            => '十';

        public char C100
            => '百';

        public char C1000
            => '千';

        public char C1_0000
            => '万';

        public char C1_0000_0000
            => '億';

        public char C1_0000_0000_0000
            => '兆';

        public char C1_0000_0000_0000_0000
            => '京';

        public char C1_0000_0000_0000_0000_0000
            => '垓';

        internal TestNumeralCharacters(char[] singleDigits)
        {
            this.SingleDigits = singleDigits;
        }
    }
}