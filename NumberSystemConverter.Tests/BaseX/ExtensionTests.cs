using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class ExtensionTests
{
    [TestMethod]
    public void MissingConvertFrom()
    {
        Assert.ThrowsExactly<ArgumentNullException>(() => ((INumberSystemConverter)null!).Convert("0", new DecimalConverter()));
    }

    [TestMethod]
    public void MissingConvertTo()
    {
        Assert.ThrowsExactly<ArgumentNullException>(() => (new DecimalConverter()).Convert("0", null!));
    }
}