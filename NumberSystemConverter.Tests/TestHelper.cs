namespace DoenaSoft.NumberSystemConverter;

internal static class TestHelper
{
    public static void TestConvert(this INumberSystemConverter converter
        , uint intValue
        , string stringValue)
    {
        var intResult = converter.ToUInt(stringValue);

        Assert.AreEqual(intValue, intResult);

        var stringResult = converter.FromUInt(intValue);

        Assert.AreEqual(stringValue, stringResult);
    }
}