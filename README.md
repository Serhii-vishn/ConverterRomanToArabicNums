# Roman to Arabic Converter
This program provides a function that converts a Roman numeral string into its Arabic numeral equivalent. For example, if the input is "XV", the function will return 15. Similarly, if the input is "IV", it will return 4.

This program not only converts Roman numerals to Arabic, but it also performs the reverse operation - converting Arabic numerals to Roman.

## Roman Numeral Conversions
The program follows the standard conversions for both Roman and Arabic numerals:

| Roman to Arabic   | Arabic to Roman  |
|-------------------|-----------------|
| I - 1             | 1 - I           |
| V - 5             | 4 - IV          |
| X - 10            | 5 - V           |
| L - 50            | 9 - IX          |
| C - 100           | 10 - X          |
| D - 500           | 40 - XL         |
| M - 1000          | 50 - L          |
|                   | 90 - XC         |
|                   | 100 - C         |
|                   | 400 - CD        |
|                   | 500 - D         |
|                   | 900 - CM        |
|                   | 1000 - M        |

## Implementation Details
### Roman to Arabic Conversion
The program employs two fundamental rules:
1. If a larger Roman numeral precedes a smaller Roman numeral, they are added together (the addition principle).
2. If a smaller Roman numeral precedes a larger one, the smaller numeral is subtracted from the larger one (the subtraction principle).
The program accurately converts Roman numerals to Arabic numerals, processing the input from right to left.

### Arabic to Roman Conversion
This conversion is performed by iteratively subtracting the largest possible Roman numeral from the given Arabic numeral. The corresponding Roman numeral is then added to the result string until the Arabic numeral is fully converted.

## Usage
To convert Roman to Arabic, call the function `ConverterRomToArabian(string romanianStr)` with a Roman numeral string as the argument. The function will return the equivalent Arabic numeral.

Example usage:
```csharp
int arabicValue = ConverterRomToArabian("XV"); // Returns 15
int anotherValue = ConverterRomToArabian("IV"); // Returns 4
```
To convert Arabic to Roman, call the function ConverterArabToRomanian(int number) with an Arabic numeral as the argument. The function will return the equivalent Roman numeral.

Example usage:
```csharp
string romanValue = ConverterArabToRomanian(15); // Returns "XV"
string anotherRomanValue = ConverterArabToRomanian(4); // Returns "IV"
```
## Note
The program does not consider non-standard representations, such as "IIIV" for 2 (which, although occasionally used by the Romans, is not within the scope of this program). As per historical guidelines:
"It is worth noting that other methods of 'subtracting' are not acceptable. For instance, the number 99 should be written as XCIX, not as IC."

## Contributing
If you'd like to contribute, please fork the repository and make your changes. Submit a pull request with a clear description of your changes. Make sure to update the README if needed.

## Installation
Clone the repository to your local machine using the following command: [Copy code](https://github.com/Serhii-vishn/ConverterRomanToArabicNums.git)
