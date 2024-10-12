namespace DoenaSoft.NumberSystemConverter;

public interface INumberSystemConverter
{
    string FromULong(ulong input);

    ulong ToULong(string input);
}