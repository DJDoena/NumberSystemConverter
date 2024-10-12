using DoenaSoft.NumberSystemConverter.Chinese;

namespace DoenaSoft.NumberSystemConverter.Tests.Chinese;

[TestClass]
public sealed class ChineseConverterTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputNull()
        => ToUInt(null!, ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputEmpty()
        => ToUInt(string.Empty, ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputWhitespace()
        => ToUInt(" ", ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntCharactersNull()
        => ToUInt("0", null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GetUIntCharactersEmpty()
          => ToUInt("0", []);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void GetUIntInvalidCharacter()
        => ToUInt("A", ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetStringCharactersNull()
      => FromUInt(0, null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GetStringCharactersEmpty()
        => FromUInt(0, []);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void NumeralCharactersNull()
        => (new TestChineseConverter((INumeralCharacters)null!)).ToUInt("");

    private static void ToUInt(string input
        , char[] validCharacters)
        => (new TestChineseConverter(validCharacters)).ToUInt(input);

    private static void FromUInt(uint input
        , char[] validCharacters)
        => (new TestChineseConverter(validCharacters)).FromUInt(input);

    private sealed class TestChineseConverter : NumeralConverterBase
    {
        internal TestChineseConverter(INumeralCharacters numeralCharacters)
            : base(numeralCharacters)
        {
        }

        internal TestChineseConverter(char[] singleDigits)
            : this(new TestNumeralCharacters(singleDigits))
        {
        }
    }

    private sealed class TestNumeralCharacters : INumeralCharacters
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

        public char C1_0000_00000
            => '亿';

        internal TestNumeralCharacters(char[] singleDigits)
        {
            this.SingleDigits = singleDigits;
        }
    }
}