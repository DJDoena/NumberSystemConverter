namespace DoenaSoft.NumberSystemConverter.Tests;

internal static class TestHelper
{
    internal static void TestFromTo(this INumberSystemConverter converter
        , uint intValue
        , string stringValue)
    {
        converter.TestTo(stringValue, intValue);

        converter.TestFrom(intValue, stringValue);
    }

    internal static void TestTo(this INumberSystemConverter converter
        , string stringValue
        , uint intValue)
    {
        var intResult = converter.ToUInt(stringValue);

        Assert.AreEqual(intValue, intResult);
    }

    internal static void TestFrom(this INumberSystemConverter converter
        , uint intValue
        , string stringValue)
    {
        var stringResult = converter.FromUInt(intValue);

        Assert.AreEqual(stringValue, stringResult);
    }
}