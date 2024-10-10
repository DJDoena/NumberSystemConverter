using NC = DoenaSoft.NumberSystemConverter.Roman.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Roman;

public sealed class NumeralInputValidator
{
    private string? _numerals;
    private List<ushort>? _numbers;
    private ushort _highestNumber;
    private string? _highestNumeral;
    private ushort _dCount;
    private ushort _cCount;
    private ushort _lCount;
    private ushort _xCount;
    private ushort _vCount;
    private ushort _iCount;
    private int _numberIndex;

    /// <summary>
    ///The code check against the following rules:
    ///The numbers have to be steady or descending
    ///You can substract C only from M and D
    ///You can substract X only from C and L
    ///You can substract I only from X and V
    ///D, L and V can only appear once
    ///C, X and I can only appear thrice in a row
    /// </summary>
    /// <exception cref="InvalidInputException" />
    public List<ushort> Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        _numerals = input;

        _numbers = new(input.Length);

        _highestNumber = NC.OneThousand;
        _highestNumeral = NC.M.ToString();
        _dCount = 0;
        _cCount = 0;
        _lCount = 0;
        _xCount = 0;
        _vCount = 0;
        _iCount = 0;

        foreach (var letter in input)
        {
            var number = NC.GetNumber(letter);

            _numbers.Add(number);
        }

        for (_numberIndex = 0; _numberIndex < _numbers.Count; _numberIndex++)
        {
            var currentNumber = this.GetCurrentNumber();

            if (_numberIndex < _numbers.Count - 1)
            {
                if (currentNumber < this.GetNextNumber())
                {
                    if (this.ValidateSubtraction())
                    {
                        continue;
                    }
                }
            }

            if (currentNumber > _highestNumber)
            {
                throw new InvalidInputException($"You cannot have '{input[_numberIndex]}' following '{_highestNumeral}'");
            }
            else
            {
                this.ValidateMaxSequentials(false);

                _highestNumber = currentNumber;

                _highestNumeral = input[_numberIndex].ToString();
            }
        }

        var result = this.GetResult();

        return result;
    }

    private bool ValidateSubtraction()
    {
        this.ValidatePowerOfTenSubtraction();

        var currentNumber = this.GetCurrentNumber();

        var nextNumber = this.GetNextNumber();

        var substraction = (ushort)(nextNumber - currentNumber);

        if (substraction > _highestNumber)
        {
            var wrongInput = $"{this.GetCurrentNumeral()}{this.GetNextNumeral()}";

            throw new InvalidInputException($"You cannot have '{wrongInput}' following '{_highestNumeral}'");
        }
        else
        {
            _highestNumeral = $"{this.GetCurrentNumeral()}{this.GetNextNumeral()}";

            if (substraction > _highestNumber)
            {
                throw new InvalidInputException($"You cannot have '{_highestNumeral}' following '{_highestNumeral}'");
            }

            _highestNumber = (ushort)(currentNumber - 1);

            _numberIndex++;

            this.ValidateMaxSequentials(true);

            return true;
        }
    }

    private void ValidatePowerOfTenSubtraction()
    {

        if (this.ValidatePowerOfTenSubtraction(NC.I, NC.V, NC.X))
        {
            return;
        }
        else if (this.ValidatePowerOfTenSubtraction(NC.X, NC.L, NC.C))
        {
            return;
        }
        else if (this.ValidatePowerOfTenSubtraction(NC.C, NC.D, NC.M))
        {
            return;
        }
        else
        {
            throw new InvalidInputException($"You cannot substract '{this.GetCurrentNumeral()}' from '{this.GetNextNumeral()}'");
        }
    }

    private bool ValidatePowerOfTenSubtraction(char romanCompare
        , char romanValid1
        , char romanValid2)
    {
        var currentNumber = this.GetCurrentNumber();

        if (currentNumber == NC.GetNumber(romanCompare))
        {
            var nextNumber = this.GetNextNumber();

            if (nextNumber != NC.GetNumber(romanValid1)
                && nextNumber != NC.GetNumber(romanValid2))
            {
                throw new InvalidInputException($"You can substract '{romanCompare}' only from '{romanValid1}' or '{romanValid2}'");
            }

            return true;
        }
        else
        {
            return false;
        }
    }

    private void ValidateMaxSequentials(bool isSubstraction)
    {
        const ushort MaxOne = 1;

        var maxCount = isSubstraction
            ? (ushort)4
            : (ushort)3;

        this.ValidateMaxSequentials(ref _dCount, MaxOne, NC.FiveHundred, "one");
        this.ValidateMaxSequentials(ref _cCount, maxCount, NC.OneHundred, "three");
        this.ValidateMaxSequentials(ref _lCount, MaxOne, NC.Fifty, "one");
        this.ValidateMaxSequentials(ref _xCount, maxCount, NC.Ten, "three");
        this.ValidateMaxSequentials(ref _vCount, MaxOne, NC.Five, "one");
        this.ValidateMaxSequentials(ref _iCount, maxCount, NC.One, "three");
    }

    private bool ValidateMaxSequentials(ref ushort count
        , ushort maxCount
        , ushort value
        , string numberWord)
    {
        if (this.GetCurrentNumber() == value)
        {
            count++;
            if (count > maxCount)
            {
                throw new InvalidInputException($"You cannot have more than {numberWord} '{this.GetCurrentNumeral()}'");
            }

            return true;
        }

        return false;
    }

    private List<ushort> GetResult()
    {
        var result = new List<ushort>(_numbers!.Count);

        for (_numberIndex = 0; _numberIndex < _numbers.Count; _numberIndex++)
        {
            var currentNumber = this.GetCurrentNumber();

            if (_numberIndex < _numbers.Count - 1)
            {
                var nextNumber = this.GetNextNumber();

                if (currentNumber < nextNumber)
                {
                    result.Add((ushort)(nextNumber - currentNumber));

                    _numberIndex++;
                }
                else
                {
                    result.Add(currentNumber);
                }
            }
            else
            {
                result.Add(currentNumber);
            }
        }

        return result;
    }

    private ushort GetCurrentNumber()
        => _numbers![_numberIndex];

    private ushort GetNextNumber()
        => _numbers![_numberIndex + 1];

    private char GetCurrentNumeral()
        => _numerals![_numberIndex];

    private char GetNextNumeral()
        => _numerals![_numberIndex + 1];
}