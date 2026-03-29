# NumberSystemConverter

Allows you to convert numbers from and to string representatios of the most common number systems:

- Binary (base 2)				(2026 = `11111101010`)
- Octal (base 8)				(2026 = `3752`)
- Decimal (base 10)				(2026 = `2026`)
- Duodecimal (base 12)			(2026 = `120↊`)
- Hexadecimal (base 16)			(2026 = `7EA`)

Language support for

- Chinese
	- simplified (common)		(2026 = `二千零二十六`)
	- simplified (financial)	(2026 = `贰仟零贰拾陆`)
	- traditional (common)		(2026 = `二千零二十六`)
	- traditional (financial)	(2026 = `貳仟零貳拾陸`)
- Japanese
	- common					(2026 = `二千二十六`)
	- financial					(2026 = `弐千弐拾六`)
- Korean
	- Hangul				(2026 = `이천이십육`, 0 = `영`)
	- Hanja				(2026 = `二千二十六`, 0 = `零`)
	- financial				(2026 = `貳仟貳拾陸`, 0 = `零`)
- Eastern Arabic				(2026 = `٢٠٢٦`)
- Persian						(2026 = `۲۰۲۶`)
- Braille						(2026 = `⠃⠚⠃⠋`)
- Roman							(2026 = `MMXXVI`)

## Installation

Install via NuGet:
```
dotnet add package DoenaSoft.NumberSystemConverter
```

## Usage Examples

### Basic Conversion

All converters implement the `INumberSystemConverter` interface with two methods:
- `string FromULong(ulong input)` - converts a number to its string representation
- `ulong ToULong(string input)` - converts a string representation back to a number

```csharp
using DoenaSoft.NumberSystemConverter.BaseX;
using DoenaSoft.NumberSystemConverter.Roman;
using DoenaSoft.NumberSystemConverter.Chinese;
using DoenaSoft.NumberSystemConverter.Japanese;
using DoenaSoft.NumberSystemConverter.Korean;

// Hexadecimal
var hexConverter = new HexadecimalConverter();
string hex = hexConverter.FromULong(2026);       // "7EA"
ulong number = hexConverter.ToULong("7EA");      // 2026

// Binary
var binaryConverter = new BinaryConverter();
string binary = binaryConverter.FromULong(2026); // "11111101010"
ulong num = binaryConverter.ToULong("11111101010"); // 2026

// Roman Numerals
var romanConverter = new NumeralConverter();
string roman = romanConverter.FromULong(2026);   // "MMXXVI"
ulong year = romanConverter.ToULong("MMXXVI");   // 2026
```

### East Asian Number Systems

#### Chinese
```csharp
using DoenaSoft.NumberSystemConverter.Chinese;

// Simplified Chinese (Common)
var commonSimplified = new CommonSimplifiedNumeralConverter();
string chinese = commonSimplified.FromULong(2026);
// Result: "二千零二十六"

// Simplified Chinese (Financial)
var financialSimplified = new FinancialSimplifiedNumeralConverter();
string chineseFin = financialSimplified.FromULong(2026);
// Result: "贰仟零贰拾陆"

// Traditional Chinese (Common)
var commonTraditional = new CommonTraditionalNumeralConverter();
string traditionalChi = commonTraditional.FromULong(2026);
// Result: "二千零二十六"

// Traditional Chinese (Financial)
var financialTraditional = new FinancialTraditionalNumeralConverter();
string traditionalFin = financialTraditional.FromULong(2026);
// Result: "貳仟零貳拾陸"
```

#### Japanese
```csharp
using DoenaSoft.NumberSystemConverter.Japanese;

// Common Japanese
var commonJapanese = new CommonNumeralConverter();
string japanese = commonJapanese.FromULong(2026);
// Result: "二千二十六"

// Financial Japanese
var financialJapanese = new FinancialNumeralConverter();
string japaneseFin = financialJapanese.FromULong(2026);
// Result: "弐千弐拾六"
```

#### Korean
```csharp
using DoenaSoft.NumberSystemConverter.Korean;

// Hangul (Native Korean script)
var hangul = new HangulNumeralConverter();
string korean = hangul.FromULong(2026);
// Result: "이천이십육"

// Hanja (Chinese characters)
var hanja = new HanjaKoreanNumeralConverter();
string koreanHanja = hanja.FromULong(2026);
// Result: "二千二十六"

// Financial (Financial Hanja for banking/legal)
var financial = new FinancialKoreanNumeralConverter();
string koreanFinancial = financial.FromULong(2026);
// Result: "貳仟貳拾陸"
```

### Other Number Systems

```csharp
using DoenaSoft.NumberSystemConverter.BaseX;

// Eastern Arabic Numerals
var easternArabic = new EasternArabicDecimalConverter();
string arabic = easternArabic.FromULong(2026);   // "٢٠٢٦"

// Persian Numerals
var persian = new PersianDecimalConverter();
string persianNum = persian.FromULong(2026);     // "۲۰۲۶"

// Braille Numerals
var braille = new BrailleDecimalConverter();
string brailleNum = braille.FromULong(2026);     // "⠃⠚⠃⠋"

// Octal
var octal = new OctalConverter();
string oct = octal.FromULong(2026);              // "3752"

// Duodecimal (base 12)
var duodecimal = new DuodecimalConverter();
string duo = duodecimal.FromULong(2026);         // "120↊"
```

### Converting Between Number Systems

Use the `Convert` extension method to convert directly between any two number systems:

```csharp
using DoenaSoft.NumberSystemConverter;
using DoenaSoft.NumberSystemConverter.BaseX;
using DoenaSoft.NumberSystemConverter.Chinese;
using DoenaSoft.NumberSystemConverter.Roman;

var hex = new HexadecimalConverter();
var chinese = new CommonSimplifiedNumeralConverter();
var roman = new NumeralConverter();

// Convert hexadecimal to Chinese
string chineseNumber = hex.Convert("7EA", chinese);
// Result: "二千零二十六"

// Convert Roman to hexadecimal
string hexNumber = roman.Convert("MMXXVI", hex);
// Result: "7EA"

// Convert Chinese to binary
var binary = new BinaryConverter();
string binaryNumber = chinese.Convert("二千零二十六", binary);
// Result: "11111101010"
```

### Error Handling

```csharp
using DoenaSoft.NumberSystemConverter;

try
{
	var converter = new HexadecimalConverter();
	ulong value = converter.ToULong("INVALID!");
}
catch (InvalidInputException ex)
{
	// Handle invalid input characters
	Console.WriteLine($"Invalid input: {ex.Message}");
}

try
{
	var romanConverter = new NumeralConverter();
	// Roman numerals don't support zero
	string roman = romanConverter.FromULong(0);
}
catch (InvalidInputException ex)
{
	Console.WriteLine($"Error: {ex.Message}");
}
```

## Supported Frameworks

- .NET Standard 2.0
- .NET Framework 4.7.2
- .NET 10.0

## License

This project is licensed under the MIT License.