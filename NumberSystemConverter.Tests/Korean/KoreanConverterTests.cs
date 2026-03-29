using DoenaSoft.NumberSystemConverter.Korean;
using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Tests.Korean;

[TestClass]
public sealed class KoreanConverterTests
{
    [TestMethod]
    public void GetUIntInputNull()
        => Assert.ThrowsException<ArgumentNullException>(() => ToUInt(null!, ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetUIntInputEmpty()
        => Assert.ThrowsException<ArgumentNullException>(() => ToUInt(string.Empty, ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetUIntInputWhitespace()
        => Assert.ThrowsException<ArgumentNullException>(() => ToUInt(" ", ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetUIntCharactersNull()
        => Assert.ThrowsException<ArgumentNullException>(() => ToUInt("0", null!));

    [TestMethod]
    public void GetUIntCharactersEmpty()
          => Assert.ThrowsException<ArgumentException>(() => ToUInt("0", []));

    [TestMethod]
    public void GetUIntInvalidCharacter()
        => Assert.ThrowsException<InvalidInputException>(() => ToUInt("A", ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetStringCharactersNull()
      => Assert.ThrowsException<ArgumentNullException>(() => FromUInt(0, null!));

    [TestMethod]
    public void GetStringCharactersEmpty()
        => Assert.ThrowsException<ArgumentException>(() => FromUInt(0, []));

    [TestMethod]
    public void NumeralCharactersNull()
        => Assert.ThrowsException<ArgumentNullException>(() => (new TestKoreanConverter((IEastAsia10p4NumeralCharacters)null!)).ToULong(""));

    private static void ToUInt(string input, char[] validCharacters)
        => (new TestKoreanConverter(validCharacters)).ToULong(input);

    private static void FromUInt(ulong input, char[] validCharacters)
        => (new TestKoreanConverter(validCharacters)).FromULong(input);

    private sealed class TestKoreanConverter : KoreanNumeralConverterBase
    {
        internal TestKoreanConverter(IEastAsia10p4NumeralCharacters numeralCharacters)
            : base(numeralCharacters)
        {
        }

        internal TestKoreanConverter(char[] singleDigits)
            : this(new TestNumeralCharacters(singleDigits))
        {
        }
    }

    private sealed class TestNumeralCharacters : IEastAsia10p4NumeralCharacters
    {
        public char[] SingleDigits { get; }

        public char C10
            => '십';

        public char C100
            => '백';

        public char C1000
            => '천';

        public char C1_0000
            => '만';

        public char C1_0000_0000
            => '억';

        public char C1_0000_0000_0000
            => '조';

        public char C1_0000_0000_0000_0000
            => '경';

        public char C1_0000_0000_0000_0000_0000
            => '해';

        internal TestNumeralCharacters(char[] singleDigits)
        {
            SingleDigits = singleDigits;
        }
    }
}
