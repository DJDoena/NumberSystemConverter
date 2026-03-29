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
	- Hangul					(2026 = `이천이십육`)
	- Hanja						(2026 = `二千二十六`)
	- financial					(2026 = `貳仟貳拾陸`)
- Eastern Arabic				(2026 = `٢٠٢٦`)
- Persian						(2026 = `۲۰۲۶`)
- Braille						(2026 = `⠃⠚⠃⠋`)
- Roman							(2026 = `MMXXVI`)

## Understanding the Myriad System

East Asian number systems (Chinese, Japanese, Korean) use the **Myriad system**, which groups numbers by **powers of 10,000** (万/萬), unlike Western systems that group by powers of 1,000.

**Western System (Thousand-based):**
- 1,000 = thousand
- 1,000,000 = million (1,000 × 1,000)
- 1,000,000,000 = billion (1,000 × 1,000 × 1,000)

**East Asian Myriad System (Ten-thousand-based):**
- 10,000 = 万/萬 (wàn/man/만)
- 100,000,000 = 億/亿 (yì/oku/억) = 10,000 × 10,000
- 1,000,000,000,000 = 兆 (zhào/chō/조) = 10,000 × 10,000 × 10,000
- 10,000,000,000,000,000 = 京 (jīng/kei/경) = 10,000^4

**Example: How 123,456,789 is grouped**
```
Western:     123,456,789 (123 million, 456 thousand, 789)
East Asian:  1,2345,6789 (1億 2345万 6789)
Chinese:     "一億二千三百四十五万六千七百八十九"
```

The Myriad system creates natural breaks at every 10,000 rather than every 1,000.

## Alternate Character Support

The library accepts multiple character variants when converting text to numbers, but always outputs the primary/standard character when converting numbers to text. This follows the principle: **"Liberal in what you accept, conservative in what you send"**.

**Chinese Alternates (20 total):**
- Zero: 〇, 空, 洞 (for 零)
- Digits: 幺/蜀(1), 两/兩/俩/倆(2), 仨(3), 拐(7), 勾(9)
- Small units: 呀(10), 念/廿(20), 卅(30), 卌(40), 皕(200)
- Large units: 经/經 (historical variants for 京 at 10^16)

**Japanese Alternates (2 total):**
- Zero: 〇 (for 零)
- 10,000: 萬 (traditional form for 万)

**Korean Alternates (7 total):**
- Zero: 공 (for 영 in Hangul), 〇 (for 零 in Hanja/Financial)
- 1,000: 阡 (for 仟 in Financial)
- 10,000: 万/萬 (for 만)
- 10^12: 兆 (for 조)
- 10^16: 京 (for 경)

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
var romanConverter = new RomanNumeralConverter();
string roman = romanConverter.FromULong(2026);   // "MMXXVI"
ulong year = romanConverter.ToULong("MMXXVI");   // 2026
```

### East Asian Number Systems

#### Chinese
```csharp
using DoenaSoft.NumberSystemConverter.Chinese;

// Simplified Chinese (Common)
var commonSimplified = new ChineseCommonSimplifiedNumeralConverter();
string chinese = commonSimplified.FromULong(2026);
// Result: "二千零二十六"

// Simplified Chinese (Financial)
var financialSimplified = new ChineseFinancialSimplifiedNumeralConverter();
string chineseFin = financialSimplified.FromULong(2026);
// Result: "贰仟零贰拾陆"

// Traditional Chinese (Common)
var commonTraditional = new ChineseCommonTraditionalNumeralConverter();
string traditionalChi = commonTraditional.FromULong(2026);
// Result: "二千零二十六"

// Traditional Chinese (Financial)
var financialTraditional = new ChineseFinancialTraditionalNumeralConverter();
string traditionalFin = financialTraditional.FromULong(2026);
// Result: "貳仟零貳拾陸"
```

#### Japanese
```csharp
using DoenaSoft.NumberSystemConverter.Japanese;

// Common Japanese
var commonJapanese = new JapaneseCommonNumeralConverter();
string japanese = commonJapanese.FromULong(2026);
// Result: "二千二十六"

// Financial Japanese
var financialJapanese = new JapaneseFinancialNumeralConverter();
string japaneseFin = financialJapanese.FromULong(2026);
// Result: "弐千弐拾六"
```

#### Korean
```csharp
using DoenaSoft.NumberSystemConverter.Korean;

// Hangul (Native Korean script)
var hangul = new KoreanHangulNumeralConverter();
string korean = hangul.FromULong(2026);
// Result: "이천이십육"

// Hanja (Chinese characters)
var hanja = new KoreanHanjaNumeralConverter();
string koreanHanja = hanja.FromULong(2026);
// Result: "二千二十六"

// Financial (Financial Hanja for banking/legal)
var financial = new KoreanFinancialNumeralConverter();
string koreanFinancial = financial.FromULong(2026);
// Result: "貳仟貳拾陸"
```

#### Alternate Character Support

```csharp
// Example: Chinese accepts historical variants
var converter = new ChineseFinancialSimplifiedNumeralConverter();
converter.FromULong(1_0000_0000_0000_0000); // Returns: "壹京" (primary)
converter.ToULong("壹京"); // Accepts primary ✅
converter.ToULong("壹经"); // Accepts simplified variant ✅
converter.ToULong("壹經"); // Accepts traditional variant ✅

// Example: Korean accepts Chinese character alternates
var korean = new KoreanFinancialNumeralConverter();
korean.FromULong(10000); // Returns: "壹만" (Korean primary)
korean.ToULong("壹만"); // Korean primary ✅
korean.ToULong("壹万"); // Chinese simplified ✅
korean.ToULong("壹萬"); // Chinese traditional ✅
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