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
    //private int _numberIndex;

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

        _highestNumber = NC.D1000;
        _highestNumeral = NC.R1000.ToString();
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

        for (var numberIndex = 0; numberIndex < _numbers.Count; numberIndex++)
        {
            var currentNumber = this.GetCurrentNumber(numberIndex);

            if (numberIndex < _numbers.Count - 1)
            {
                if (currentNumber < this.GetNextNumber(numberIndex))
                {
                    this.ValidateSubtraction(ref numberIndex);

                    continue;
                }
            }

            if (currentNumber > _highestNumber)
            {
                throw new InvalidInputException($"You cannot have '{input[numberIndex]}' following '{_highestNumeral}'");
            }
            else
            {
                this.ValidateMaxSequentials(false, numberIndex);

                _highestNumber = currentNumber;

                _highestNumeral = input[numberIndex].ToString();
            }
        }

        var result = this.GetResult();

        return result;
    }

    private void ValidateSubtraction(ref int numberIndex)
    {
        this.ValidatePowerOfTenSubtraction(numberIndex);

        var currentNumber = this.GetCurrentNumber(numberIndex);

        var nextNumber = this.GetNextNumber(numberIndex);

        var substraction = (ushort)(nextNumber - currentNumber);

        if (substraction > _highestNumber)
        {
            var wrongInput = $"{this.GetCurrentNumeral(numberIndex)}{this.GetNextNumeral(numberIndex)}";

            throw new InvalidInputException($"You cannot have '{wrongInput}' following '{_highestNumeral}'");
        }
        else
        {
            _highestNumeral = $"{this.GetCurrentNumeral(numberIndex)}{this.GetNextNumeral(numberIndex)}";

            _highestNumber = (ushort)(currentNumber - 1);

            numberIndex++;

            this.ValidateMaxSequentials(true, numberIndex);
        }
    }

    private void ValidatePowerOfTenSubtraction(int numberIndex)
    {

        if (this.ValidatePowerOfTenSubtraction(NC.R1, NC.R5, NC.R10, numberIndex))
        {
            return;
        }
        else if (this.ValidatePowerOfTenSubtraction(NC.R10, NC.R50, NC.R100, numberIndex))
        {
            return;
        }
        else if (this.ValidatePowerOfTenSubtraction(NC.R100, NC.R500, NC.R1000, numberIndex))
        {
            return;
        }
        else
        {
            throw new InvalidInputException($"You cannot substract '{this.GetCurrentNumeral(numberIndex)}' from '{this.GetNextNumeral(numberIndex)}'");
        }
    }

    private bool ValidatePowerOfTenSubtraction(char romanCompare
        , char romanValid1
        , char romanValid2
        , int numberIndex)
    {
        var currentNumber = this.GetCurrentNumber(numberIndex);

        if (currentNumber == NC.GetNumber(romanCompare))
        {
            var nextNumber = this.GetNextNumber(numberIndex);

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

    private void ValidateMaxSequentials(bool isSubstraction
        , int numberIndex)
    {
        const ushort MaxOne = 1;

        var maxCount = isSubstraction
            ? (ushort)4
            : (ushort)3;

        this.ValidateMaxSequentials(ref _dCount, MaxOne, NC.D500, "one", numberIndex);
        this.ValidateMaxSequentials(ref _cCount, maxCount, NC.D100, "three", numberIndex);
        this.ValidateMaxSequentials(ref _lCount, MaxOne, NC.D50, "one", numberIndex);
        this.ValidateMaxSequentials(ref _xCount, maxCount, NC.D10, "three", numberIndex);
        this.ValidateMaxSequentials(ref _vCount, MaxOne, NC.D5, "one", numberIndex);
        this.ValidateMaxSequentials(ref _iCount, maxCount, NC.D1, "three", numberIndex);
    }

    private bool ValidateMaxSequentials(ref ushort count
        , ushort maxCount
        , ushort value
        , string numberWord
        , int numberIndex)
    {
        if (this.GetCurrentNumber(numberIndex) == value)
        {
            count++;
            if (count > maxCount)
            {
                throw new InvalidInputException($"You cannot have more than {numberWord} '{this.GetCurrentNumeral(numberIndex)}'");
            }

            return true;
        }

        return false;
    }

    private List<ushort> GetResult()
    {
        var result = new List<ushort>(_numbers!.Count);

        for (var numberIndex = 0; numberIndex < _numbers.Count; numberIndex++)
        {
            this.AddResultNumber(result, ref numberIndex);
        }

        return result;
    }

    private void AddResultNumber(List<ushort> result
        , ref int numberIndex)
    {
        var currentNumber = this.GetCurrentNumber(numberIndex);

        if (numberIndex < _numbers!.Count - 1)
        {
            var nextNumber = this.GetNextNumber(numberIndex);

            if (currentNumber < nextNumber)
            {
                result.Add((ushort)(nextNumber - currentNumber));

                numberIndex++;
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

    private ushort GetCurrentNumber(int numberIndex)
        => _numbers![numberIndex];

    private ushort GetNextNumber(int numberIndex)
        => _numbers![numberIndex + 1];

    private char GetCurrentNumeral(int numberIndex)
        => _numerals![numberIndex];

    private char GetNextNumeral(int numberIndex)
        => _numerals![numberIndex + 1];
}