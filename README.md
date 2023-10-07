# Roman to Arabic Converter
This program provides a function that converts a Roman numeral string into its Arabic numeral equivalent. For example, if the input is "XV", the function will return 15. Similarly, if the input is "IV", it will return 4.

## Roman Numeral Conversions
The program follows the standard conversions for Roman numerals:

- I - 1
- V - 5
- X - 10
- L - 50
- C - 100
- D - 500
- M - 1000

The program does not consider non-standard representations, such as "IIIV" for 2 (which, although occasionally used by the Romans, is not within the scope of this program). As per historical guidelines:
"It is worth noting that other methods of 'subtracting' are not acceptable. For instance, the number 99 should be written as XCIX, not as IC."

## Implementation Details
To achieve this conversion, the program uses two basic rules:
If a larger number precedes a smaller number, they are added (the addition principle).
If a smaller number precedes a larger one, the smaller number is subtracted from the larger one (the subtraction principle).
This program provides accurate conversion of Roman numerals to Arabic numerals according to these established rules. The entered Roman numeral is converted from right to left.
This program ensures accurate conversion from Roman to Arabic numerals in compliance with these established rules.

## Usage
To use the program, call the provided function `ConverterRomToArabian (string romanianStr)` with a Roman numeral string as the argument. The function will return the equivalent Arabic numeral.

Example usage:
```csharp
int arabicValue = ConverterRomToArabian("XV"); // Returns 15
int anotherValue = ConverterRomToArabian("IV"); // Returns 4
```
or you can transfer the value from the console (protection against incorrect input is available):
```csharp
Console.Write("Enter romanian num: "); string romanianStr = Console.ReadLine();
  if (ValidateInput(romanianStr))
      Console.WriteLine("Arabian num: " + ConverterRomToArabian(romanianStr.ToUpper()));
  else
      Console.WriteLine("Error! invalid symbol. Try Again");
```
## Note
This program assumes valid Roman numeral input adhering to standard conventions. Non-standard representations are not considered within the scope of this implementation.

## Contributing
If you'd like to contribute, please fork the repository and make your changes. Submit a pull request with a clear description of your changes. Make sure to update the README if needed.

## Installation
Clone the repository to your local machine using the following command: [Copy code](https://github.com/Serhii-vishn/ConverterRomanToArabicNums.git)
