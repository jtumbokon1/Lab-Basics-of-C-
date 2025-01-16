/*
 * CPRG 211 Lab 0 Activity
 * Author: Jirch Tumbokon
 * When: Winter 2025
 */

// get low and high int numbers
// low must be positive
// high must be greater than low

using System.Runtime.CompilerServices;
using Lab0;

int low, high;
int diff;   // difference between low and high

low = Utilities.GetPositiveInt("low number");

high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue); // the largest int possible

// calculate and print the difference
diff = high - low;
Console.WriteLine($"The difference between {low} and {high} is {diff}");

// list to store numbers
List<int> numbers = new List<int>();
for (int i = low; i <= high; i++)
{
    numbers.Add(i);
}

// display numbers in list
Console.WriteLine("Numbers in the list:");
for (int i = 0; i <= diff; i++)
{
    Console.WriteLine(numbers[i]);
}

// create a file named "numbers.txt" and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt"); // located in the same folder as the .exe file
for (int i = numbers.Count - 1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close(); // important to finalize the writing
Console.WriteLine("File written");

int sum = 0;

// reads file named "numbers.txt" and gives sum of all numbers
StreamReader streamReader = new StreamReader("numbers.txt");
string? line;
while ((line = streamReader.ReadLine()) != null)
{
    sum += int.Parse(line);
}
streamReader.Close();

Console.WriteLine("Sum of numbers:");
Console.WriteLine($"{sum}");

// check if num is prime and prints result
Console.WriteLine("Prime numbers:");
for (int i = 0; i <= diff; i++)
{
    if (Utilities.IsPrime(numbers[i])) // only return if number is prime
    {
        Console.WriteLine($"{numbers[i]}");
    }
}