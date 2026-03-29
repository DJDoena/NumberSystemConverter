using DoenaSoft.NumberSystemConverter.Korean;
using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Tests.Korean;

[TestClass]
public sealed class KoreanConverterTests
{
    [TestMethod]
    public void GetUIntInputNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(null!, ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetUIntInputEmpty()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(string.Empty, ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetUIntInputWhitespace()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(" ", ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetUIntCharactersNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt("0", null!));

    [TestMethod]
    public void GetUIntCharactersEmpty()
          => Assert.ThrowsExactly<ArgumentException>(() => ToUInt("0", []));

    [TestMethod]
    public void GetUIntInvalidCharacter()
        => Assert.ThrowsExactly<InvalidInputException>(() => ToUInt("A", ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구']));

    [TestMethod]
    public void GetStringCharactersNull()
      => Assert.ThrowsExactly<ArgumentNullException>(() => FromUInt(0, null!));

    [TestMethod]
    public void GetStringCharactersEmpty()
        => Assert.ThrowsExactly<ArgumentException>(() => FromUInt(0, []));

    [TestMethod]
    public void NumeralCharactersNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => (new TestKoreanConverter((IEastAsia10p4NumeralCharacters)null!)).ToULong(""));

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
