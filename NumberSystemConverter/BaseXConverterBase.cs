namespace DoenaSoft.NumberSystemConverter;

public abstract class BaseXConverterBase : INumberSystemConverter
{
    protected abstract char[] ValidCharacters { get; }

    public uint Base
        => (uint)this.ValidCharacters.Length;

    public virtual uint ToUInt(string input)
        => GenericConverter.GetDecimalValue(input, this.ValidCharacters);

    public string FromUInt(uint input)
        => GenericConverter.GetStringValue(input, this.ValidCharacters);
}