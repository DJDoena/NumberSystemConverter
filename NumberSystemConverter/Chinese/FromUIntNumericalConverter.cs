using System.Text;
using NC = DoenaSoft.NumberSystemConverter.Chinese.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Chinese;

internal sealed class FromUIntNumericalConverter
{
    private readonly INumeralCharacters _numeralCharacters;

    internal FromUIntNumericalConverter(INumeralCharacters numeralCharacters)
    {
        _numeralCharacters = numeralCharacters;
    }

    public string FromUInt(uint input)
    {
        if (input == 0)
        {
            return _numeralCharacters.SingleDigits[0].ToString();
        }

        var numberSections = GetNumberSections(input);

        var characterSections = numberSections
            .Select(this.ToCharacters)
            .ToList();

        var result = this.GetResult(characterSections);

        return result;
    }

    private static List<uint> GetNumberSections(uint input)
    {
        var number = input;

        var numberSections = new List<uint>();

        while (number > 0)
        {
            var remainder = number % NC.D1_0000;

            numberSections.Add(remainder);

            number /= NC.D1_0000;
        }

        return numberSections;
    }

    private string ToCharacters(uint input)
    {
        var number = input;

        var thousands = number / NC.D1000;

        number -= thousands * NC.D1000;

        var hundreds = number / NC.D100;

        number -= hundreds * NC.D100;

        var tens = number / NC.D10;

        number -= tens * NC.D10;

        var ones = number;

        var zeroInserted = false;

        var resultBuilder = new StringBuilder();

        if (thousands > 0)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[thousands]}{_numeralCharacters.C1000}");
        }
        else if (hundreds > 0 || tens > 0 || ones > 0)
        {
            resultBuilder.Append(this.GetZero());

            zeroInserted = true;
        }

        if (hundreds > 0)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[hundreds]}{_numeralCharacters.C100}");

            zeroInserted = false;
        }
        else if (!zeroInserted && (tens > 0 || ones > 0))
        {
            resultBuilder.Append(this.GetZero());

            zeroInserted = true;
        }

        if (tens > 1)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[tens]}{_numeralCharacters.C10}");
        }
        else if (tens == 1)
        {
            if (thousands > 0 || hundreds > 0)
            {
                resultBuilder.Append($"{_numeralCharacters.SingleDigits[tens]}{_numeralCharacters.C10}");
            }
            else
            {
                resultBuilder.Append($"{_numeralCharacters.C10}");
            }
        }
        else if (!zeroInserted && ones > 0)
        {
            resultBuilder.Append(this.GetZero());
        }

        if (ones > 0)
        {
            resultBuilder.Append($"{_numeralCharacters.SingleDigits[ones]}");
        }

        var result = resultBuilder.ToString();

        return result;
    }



    private string GetResult(List<string> characterSections)
    {
        var zero = this.GetZero();

        var resultBuilder = new StringBuilder();

        int sectionIndex;
        for (sectionIndex = 0; sectionIndex < characterSections.Count - 1; sectionIndex++)
        {
            var currentSection = characterSections[sectionIndex];

            if (currentSection != zero)
            {
                this.InsertSection(resultBuilder, currentSection, sectionIndex);
            }
            else
            {
                var nextSection = characterSections[sectionIndex + 1];

                if (!nextSection.StartsWith(zero))
                {
                    resultBuilder.Append(zero);
                }
            }
        }

        sectionIndex = characterSections.Count - 1;

        this.InsertSection(resultBuilder, characterSections[sectionIndex], sectionIndex);

        if (resultBuilder.Length > 1 && resultBuilder[0] == zero[0])
        {
            resultBuilder.Remove(0, 1);
        }

        var result = resultBuilder.ToString();

        return result;
    }

    private void InsertSection(StringBuilder resultBuilder
        , string section
        , int sectionIndex)
    {
        if (!string.IsNullOrEmpty(section))
        {
            if (section != this.GetZero())
            {
                resultBuilder.Insert(0, $"{section}{this.GetUnit(sectionIndex)}");
            }
            else
            {
                resultBuilder.Insert(0, $"{section}");
            }
        }
    }

    private string GetUnit(int sectionIndex)
    {
        switch (sectionIndex)
        {
            case 0:
                {
                    return string.Empty;
                }
            case 1:
                {
                    return _numeralCharacters.C1_0000.ToString();
                }
            case 2:
                {
                    return _numeralCharacters.C1_0000_00000.ToString();
                }
            default:
                {
                    throw new NotSupportedException();
                }
        }
    }

    private string GetZero()
        => _numeralCharacters.SingleDigits[0].ToString();
}