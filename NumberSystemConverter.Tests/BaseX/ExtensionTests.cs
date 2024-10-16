﻿using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class ExtensionTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MissingConvertFrom()
    {
        ((INumberSystemConverter)null!).Convert("0", new DecimalConverter());
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MissingConvertTo()
    {
        (new DecimalConverter()).Convert("0", null!);
    }
}