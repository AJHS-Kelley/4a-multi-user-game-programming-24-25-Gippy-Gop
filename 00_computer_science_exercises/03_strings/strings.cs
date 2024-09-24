using System;

class Strings {
  static void Main() {
// In C# ALL STRINGS MUST USE DOUBLE-QUOTES " "

string greeting = "Eh,whats up doc?\n";
string goodbye ="Get out!\n";

// In C# strings are treated like an OBJECT that has properties and methods.
// PROPERTIES -- things that describes the object such a length, values, data types, etc.
// METHODS -- built in functions related to the object

// Length is an important property for strings.
Console.WriteLine(greeting.Length);
Console.WriteLine(goodbye.Length);

if (greeting.Length > goodbye.Length)
{
  Console.WriteLine("The greeting had more characters than the goodbye.\n");
}

//Useful String Methods

Console.WriteLine(greeting.ToUpper());// Make entire string UPPERCASE
Console.WriteLine(goodbye.ToUpper());//Make entire string lowercase

//String Concatenation "Con- Cat- Uh- Nation"
string comboString = greeting + goodbye;
Console.WriteLine(comboString);

// String Concatenation Method #2
string comboString2 = string.Concat(greeting, goodbye);
Console.WriteLine(comboString2);

// String Interpolation -- Substituting varibles into strings.
string comboString3 = $"My greeting{greeting} and my goodbye is {goodbye}.\n";
Console.WriteLine(comboString3);

// Substituting Varibles into Method 2
Console.WriteLine("My greeting is" + greeting + "and my goodbye is" + goodbye +".\n");

// Accessing Parts of Strings
//index is a specific location of a character in a string
// ALL string indexes start at 0
Console.WriteLine(goodbye[0]); // Print the character at index 0
Console.WriteLine(goodbye[4]); // Replace x with what to print the 5th char?

// Where is it in my string?
Console.WriteLine(greeting.IndexOf("y"));

//Finding parts of string
string fullName = "Billy Mays";

// What letter?
int lastInitial = fullName.IndexOf("M");

//Find the substring.
string lastName = fullName.Substring(lastInitial);

//Print it
Console.WriteLine(lastName);

  }
}