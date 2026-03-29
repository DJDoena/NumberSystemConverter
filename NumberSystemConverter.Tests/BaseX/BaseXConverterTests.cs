using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class BaseXConverterTests
{
    [TestMethod]
    public void GetUIntInputNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(null!, ['0']));

    [TestMethod]
    public void GetUIntInputEmpty()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(string.Empty, ['0']));

    [TestMethod]
    public void GetUIntInputWhitespace()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt(" ", ['0']));

    [TestMethod]
    public void GetUIntCharactersNull()
        => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt("0", null!));

    [TestMethod]
    public void GetUIntCharactersEmpty()
          => Assert.ThrowsExactly<ArgumentNullException>(() => ToUInt("0", []));

    [TestMethod]
    public void GetUIntInvalidCharacter()
        => Assert.ThrowsExactly<InvalidInputException>(() => ToUInt("A", ['B']));

    [TestMethod]
    public void GetStringCharactersNull()
      => Assert.ThrowsExactly<ArgumentNullException>(() => FromUInt(0, null!));

    [TestMethod]
    public void GetStringCharactersEmpty()
        => Assert.ThrowsExactly<ArgumentNullException>(() => FromUInt(0, []));

    private static void ToUInt(string input
        , char[] validCharacters)
        => (new TestBaseXConverter(validCharacters)).ToULong(input);

    private static void FromUInt(ulong input
        , char[] validCharacters)
        => (new TestBaseXConverter(validCharacters)).FromULong(input);

    private sealed class TestBaseXConverter : BaseXConverterBase
    {
        protected override char[] ValidCharacters { get; }

        internal TestBaseXConverter(char[] validCharacters)
        {
            this.ValidCharacters = validCharacters;
        }
    }
}