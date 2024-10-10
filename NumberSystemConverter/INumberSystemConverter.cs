namespace DoenaSoft.NumberSystemConverter;

public interface INumberSystemConverter
{
    string FromUInt(uint input);

    uint ToUInt(string input);
}