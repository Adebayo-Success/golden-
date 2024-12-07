// // // See https://aka.ms/new-console-template for more information
// // using System.Xml;
using System.Runtime.InteropServices;

string myText = "Formal letter";
var result = Algorithms.GetVowelPosition(myText);
Console.WriteLine($"Vowel Position: " + string.Join(" , ", result));

string name = "Ade1234mola";
string characters = Algorithms.ShiftLetters(name);
Console.WriteLine($"letters in: {characters}");

string names = "Ademola";
string letter = Algorithms.TransformCase(names);
Console.WriteLine($"letters in: {letter}");

string myName = "Success";
string letters = Algorithms.SwapPairs(myName);
Console.WriteLine($"letters in: {letters}");

string input = "Hello";
char c1 = 'o';
char c2 = 'a';
string Chars = Algorithms.ReplaceCharacters(input, c1, c2);
Console.WriteLine($"{Chars}");

