namespace DoenaSoft.NumberSystemConverter;

public abstract class BaseXConverterBase : INumberSystemConverter
{
    protected abstract char[] ValidCharacters { get; }

    public uint Base
        => (uint)this.ValidCharacters.Length;

    public virtual uint ToUInt(string input)
        => GenericConverter.GetUInt(input, this.ValidCharacters);

    public string FromUInt(uint input)
        => GenericConverter.GetString(input, this.ValidCharacters);
}