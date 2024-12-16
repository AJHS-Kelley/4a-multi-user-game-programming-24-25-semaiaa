using System;
class Strings {
  static void Main() {
  }} // In C# ALL STRINGS MUST USE DOUBLE-QUOTES " "

  string greeting = "Hello, how are you? Won't you tell me your name?\n";
  

    





Console.WriteLine(greeting.Length);
Console.WriteLine(greeting.)

If (greeting.Length > goodbye.Length)
{
  Console.WriteLine("The greeting has more charaters than goodbye. \n")
}

// Useful String methods 

Console.WriteLine(greeting.ToUpper()); // Make entire string UPPERCASE
Console.WriteLine(greeting.ToUpper()); // Make entire string lowercase

// String Concatenation "Con-Cat-Uh-Nation"
string comboString = greeting + goodbye; 
Console.WriteLine(combostring); 

// String Concatenation Method #2
string combostring2 = string.Concat(greeting.goodbye); 
Console.WriteLine(comboString2); 

// String Interpolation -- Substring variables into strings, 
string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}.\n";
Console.WriteLine(comboString3); 

// Substring Variables into Strings Method 2
Console.WriteLine("My greeting is " + greeting + "and my goodbye is " + goodbye + ".\n"); 

// Accessing Parts of Strings 
// Index is a specific location of a charater in a string 
// ALL string indexes start at 0 
Console.WriteLine(goodbye[0]); // Print the charater at index 0. 
Console.WriteLine(goodbye[4]); // Replace x with what to print the 5th character? 

// Where is it in my string?
Console.WriteLine(greeting.IndexOf("y)")); 

// Where is it in my string?
Console.WriteLine(greeting.IndexOf("y")); 

// Finding parts of a string 
string fullName = "Billy Mays"; 

// What Letter?
int lastInitial = fullName.IndexOf("M");

// Find the substring. 
string lastName = fullName.Substring(lastInitial);

// Print it. 
Console.WriteLine(lastName)                                                                                     
