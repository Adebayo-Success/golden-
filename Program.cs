// // // // See https://aka.ms/new-console-template for more information
// // // using System.Xml;
// using System.Runtime.InteropServices;

// string myText = "Formal letter";
// var result = Algorithms.GetVowelPosition(myText);
// Console.WriteLine($"Vowel Position: " + string.Join(" , ", result));

// string name = "Ade1234mola";
// string characters = Algorithms.ShiftLetters(name);
// Console.WriteLine($"letters in: {characters}");

// string names = "Ademola";
// string letter = Algorithms.TransformCase(names);
// Console.WriteLine($"letters in: {letter}");

// string myName = "Success";
// string letters = Algorithms.SwapPairs(myName);
// Console.WriteLine($"letters in: {letters}");

// // string input = "Hello";
// // char c1 = 'o';
// // char c2 = 'a';
// // string Chars = Algorithms.ReplaceCharacters(input, c1, c2);
// // Console.WriteLine($"{Chars}");


// class ExceptionsDemo
// {
//     static void Main()
//     {
//         string fileName = "WrongTextFile.txt";
//         ReadFile(fileName);
//     }
//     static void ReadFile(string fileName)
//     {
//         TextReader reader = new StreamReader(fileName);
//         string line = reader.ReadLine()!;
//         Console.WriteLine(line);
//         reader.Close();
//     }
// }


// Declare some variables
byte centuries = 20;
ushort years = 2000;
uint days = 730480;
ulong hours = 17531520;
// Print the result on the console
Console.WriteLine(centuries + " centuries are " + years +
" years, or " + days + " days, or " + hours + " hours.");
// Console output:
// 20 centuries are 2000 years, or 730480 days, or 17531520
// hours.
ulong maxIntValue = UInt64.MaxValue;
Console.WriteLine(maxIntValue); // 18446744073709551615




