namespace DoenaSoft.NumberSystemConverter.Korean;

public sealed class HangulNumeralCharacters : NumeralCharacterBase
{
    public override char[] SingleDigits
        => ['영', '일', '이', '삼', '사', '오', '육', '칠', '팔', '구'];

    public override char C10
        => '십';

    public override char C100
        => '백';

    public override char C1000
        => '천';
}
