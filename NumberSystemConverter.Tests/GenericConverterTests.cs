namespace DoenaSoft.NumberSystemConverter;

[TestClass]
public sealed class GenericConverterTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MissingConvertFrom()
    {
        GenericConverter.Convert("0", null!, new DecimalConverter());
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MissingConvertTo()
    {
        GenericConverter.Convert("0", new DecimalConverter(), null!);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputNull()
        => GenericConverter.GetUInt(null!, ['0']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputEmpty()
        => GenericConverter.GetUInt(string.Empty, ['0']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntInputWhitespace()
        => GenericConverter.GetUInt(" ", ['0']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntCharactersNull()
        => GenericConverter.GetUInt("0", null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetUIntCharactersEmpty()
        => GenericConverter.GetUInt("0", []);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void GetUIntInvalidCharacterEmpty()
        => GenericConverter.GetUInt("A", ['B']);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetStringCharactersNull()
        => GenericConverter.GetString(0, null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetStringCharactersEmpty()
        => GenericConverter.GetString(0, []);
}