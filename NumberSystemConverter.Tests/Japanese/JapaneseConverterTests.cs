using DoenaSoft.NumberSystemConverter.Chinese;
using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Tests.Japanese;

[TestClass]
public sealed class JapaneseConverterTests
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
        => (new TestChineseConverter((I10p4NumeralCharacters)null!)).ToULong("");

    private static void ToUInt(string input
        , char[] validCharacters)
        => (new TestChineseConverter(validCharacters)).ToULong(input);

    private static void FromUInt(ulong input
        , char[] validCharacters)
        => (new TestChineseConverter(validCharacters)).FromULong(input);

    private sealed class TestChineseConverter : NumeralConverterBase
    {
        internal TestChineseConverter(I10p4NumeralCharacters numeralCharacters)
            : base(numeralCharacters)
        {
        }

        internal TestChineseConverter(char[] singleDigits)
            : this(new TestNumeralCharacters(singleDigits))
        {
        }
    }

    private sealed class TestNumeralCharacters : I10p4NumeralCharacters
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