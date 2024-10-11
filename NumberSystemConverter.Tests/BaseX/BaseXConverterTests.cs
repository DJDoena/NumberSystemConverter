using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class BaseXConverterTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputNull()
        => ToUInt(null!, ['0']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputEmpty()
        => ToUInt(string.Empty, ['0']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputWhitespace()
        => ToUInt(" ", ['0']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntCharactersNull()
        => ToUInt("0", null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntCharactersEmpty()
          => ToUInt("0", []);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void GetUIntInvalidCharacter()
        => ToUInt("A", ['B']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetStringCharactersNull()
      => FromUInt(0, null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetStringCharactersEmpty()
        => FromUInt(0, []);

    private static void ToUInt(string input
        , char[] validCharacters)
        => (new TestBaseXConverter(validCharacters)).ToUInt(input);

    private static void FromUInt(uint input
        , char[] validCharacters)
        => (new TestBaseXConverter(validCharacters)).FromUInt(input);

    private sealed class TestBaseXConverter : BaseXConverterBase
    {
        protected override char[] ValidCharacters { get; }

        internal TestBaseXConverter(char[] validCharacters)
        {
            this.ValidCharacters = validCharacters;
        }
    }
}