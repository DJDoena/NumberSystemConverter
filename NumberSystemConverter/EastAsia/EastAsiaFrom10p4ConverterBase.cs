using System.Text;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.EastAsiaNumeralConstants;

namespace DoenaSoft.NumberSystemConverter.EastAsia;

internal abstract class EastAsiaFrom10p4ConverterBase(IEastAsia10p4NumeralCharacters numeralCharacters)
{
    protected readonly IEastAsia10p4NumeralCharacters _numeralCharacters = ValidateNumeralCharacters(numeralCharacters);

    private static IEastAsia10p4NumeralCharacters ValidateNumeralCharacters(IEastAsia10p4NumeralCharacters numeralCharacters)
    {
        if (numeralCharacters == null)
        {
            throw new ArgumentNullException(nameof(numeralCharacters));
        }

        if (numeralCharacters.SingleDigits == null)
        {
            throw new ArgumentNullException(nameof(numeralCharacters), "SingleDigits cannot be null");
        }

        if (numeralCharacters.SingleDigits.Length == 0)
        {
            throw new ArgumentException("SingleDigits cannot be empty", nameof(numeralCharacters));
        }

        return numeralCharacters;
    }

    public string Convert(ulong input)
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

    private static List<ulong> GetNumberSections(ulong input)
    {
        var number = input;

        var numberSections = new List<ulong>();

        while (number > 0)
        {
            var remainder = number % NC.D1_0000;

            numberSections.Add(remainder);

            number /= NC.D1_0000;
        }

        return numberSections;
    }

    protected abstract string ToCharacters(ulong input);

    private string GetResult(List<string> characterSections)
    {
        var zero = this.GetZero();

        var resultBuilder = new StringBuilder();

        for (var sectionIndex = characterSections.Count - 1; sectionIndex > 0; sectionIndex--)
        {
            var currentSection = characterSections[sectionIndex];

            if (currentSection != zero)
            {
                this.AppendSection(resultBuilder, currentSection, sectionIndex);
            }
            else
            {
                var nextSection = characterSections[sectionIndex - 1];

                if (!nextSection.StartsWith(zero))
                {
                    resultBuilder.Append(zero);
                }
            }
        }

        this.AppendSection(resultBuilder, characterSections[0], 0);

        var result = resultBuilder.ToString();

        if (result.Length > 1)
        {
            result = result.Trim(zero[0]);
        }

        return result;
    }

    private void AppendSection(StringBuilder resultBuilder
        , string section
        , int sectionIndex)
    {
        if (!string.IsNullOrEmpty(section) && section != this.GetZero())
        {
            resultBuilder.Append($"{section}{this.GetUnit(sectionIndex)}");
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
                    return _numeralCharacters.C1_0000_0000.ToString();
                }
            case 3:
                {
                    return _numeralCharacters.C1_0000_0000_0000.ToString();
                }
            case 4:
                {
                    return _numeralCharacters.C1_0000_0000_0000_0000.ToString();
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