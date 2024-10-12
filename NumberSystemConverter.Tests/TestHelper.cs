namespace DoenaSoft.NumberSystemConverter.Tests;

internal static class TestHelper
{
    internal static void TestFromTo(this INumberSystemConverter converter
        , ulong intValue
        , string stringValue)
    {
        //converter.TestTo(stringValue, intValue);

        converter.TestFrom(intValue, stringValue);
    }

    internal static void TestTo(this INumberSystemConverter converter
        , string stringValue
        , ulong intValue)
    {
        var intResult = converter.ToULong(stringValue);

        Assert.AreEqual(intValue, intResult);
    }

    internal static void TestFrom(this INumberSystemConverter converter
        , ulong intValue
        , string stringValue)
    {
        var stringResult = converter.FromULong(intValue);

        Assert.AreEqual(stringValue, stringResult);
    }
}