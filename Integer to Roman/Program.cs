using System;

// This Practies convert to Roman numerals the input numbers 
// In this problem I used a simple algorithm



class MainCLASS
{
    public static void Main()
    {
        int number;
        Console.WriteLine("Please enter a number into the system. (1 - 3999)");
        do
        {
            number = Convert.ToInt32(Console.ReadLine());
        } while (number > 3999 || number < 1);   // Constraints: 1 <= num <= 3999

        Console.WriteLine(ConvertToRomanNumerals(number));
    }

     
    public static string ConvertToRomanNumerals(int number) 
    // in This practies ,ConvertToRomanNumerals functionu do this conversion
    {
        string output = "";

        //I defined two different arrays with roman numerals and integer values
         string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] SymbolsValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        int step = 0;

    // this program convert to Roman Numerals step by step with while loops 
        while (number != 0)
        {
            while (SymbolsValues[step] <= number)
            {
                output += romanSymbols[step];
                number -= SymbolsValues[step];
            }
            step++;
        }

        return output;
    }
}
