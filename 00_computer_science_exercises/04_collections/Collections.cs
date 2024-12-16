// Collection Example, Semaia Encalade, v0.0
using System; 
using System.Linq; 
using System.Collections;


using System;
class Collections {
  static void Main() { // DO NOT DELETE
  /*
  In C# a collection is known as an ARRAY. 
  -- EACH ITEM IN THE ARRAY IS AN ELEMENT
  -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED
  -- CONTENTS OF EACH ELEMENT CAN CHANGE
  -- ALWAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION
  -- POSITION OF THE ELEMENT IS THE INDEX
  -- FIRST ELEMENT INDEX IS 0
  */

  // DECLARING AND DEFINING AN ARRAY
  // string [] breakFastFoods = {"Bacon", "Waffals", "Sausage", "Eggs", "Grits"};
  // int[] testScores = {0, 25, 15, 75, 99};
  // double[]GPA = {0.27D, 1,99D, 4.02D, 0.0D, 3.25D};

  // Print Array Contents -- All Elements on Single Line
  // Console.WriteLine("The elements of each array are:\n"); 
  // Console.WriteLine("breakFastFoods: \n" + String.Join(",", breakfastFoods));
  // Console.WriteLine(); // Print an empty line to the screen 
  /*
  // Print Array Contents -- All Elements on Single Line
  Console.WriteLine("The elements of each array are:\n"); 
  Console.WriteLine("breakFastFoods: \n" + String.Join("\n", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen

  // How long is my array? BETERNIMING ARRAY LENGTH
  Console.WriteLine("The length of the breakFastFoods array is: " + breakfastFoods.Length);
  // .Length is known as a PROPERTY of the array.

  // Accesing Elements in the array with the index
  Console.WriteLine("The first element of the breakFastFoods array is: " + breakfastFoods[0]);
  // PRINT THE 2nd ELEMENT OF THE testScores array
  // PRINT THE 3rd ELEMENT OF THE GPA array
   */ /*
  // Shortcut to Access Last Item in an Array
  Console.WriteLine("The last element of breakFastFoods is: " + breakFastFoods[breakFastfoods.Length - 1]); 
  Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length - 1]); 

  // CHANGING ELEMENTS IN THE ARRAY
  breakfastFoods[2] = "Green Eggs and Ham", 
  testScores[0] = -1; 
  GPA[1] = 4.0D; 
    Console.WriteLine("The elements of each array are:\n"); 
  Console.WriteLine("breakFastFoods: \n" + String.Join("\n", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen
  */

// COMMON ERRORS WITH ARRAYS
// Console.WriteLine(breakfastFoods [99]); // Index out of bounds -- Accessing index that des not exist in the array. 

// testScores[0] = "99"; // Error Message "Cannot implicitly convert dataType to dataType"
// Trying to putincorrect data type into the array. 

// COMMON ARRAY MEATHODS -- Ways to work with the array data. 
// Sorting an Array
// int[] intArr = {-25, 50, 68, 523, -1205, 99918582, -1, 55, 0, 124}; 
// string[] zooAnimals = {"Monkey", "Zebra", "Elephant", "Moose", "Iguana"}; 

// Array.Sort(intArr); 
// Array.Sort(zooAnimals);
// // Array.Sort will sort string arrays ALPHABETICALLY A-Z and numberical arrays from LEAST TO GREATEST
//   Console.WriteLine("The elements of each array are:\n"); 
//   Console.WriteLine("zooAnimals after Array.Sort(): \n" + String.Join(",", zooAnimals));
//   Console.WriteLine(); // Print an empty line to the screen 

//   // Fining the MIN, MAX, and SUM for numerical arrays.
//   Console.WriteLine("The MINIMUM value for intArr is: " + intArr.Min());
//   Console.WriteLine("The MAXIMUM value for intArr is: " + intArr.Max());
//   Console.WriteLine("The SUM value for intArr is: " + intArr.Sum()); 

// ArrayList --> Basically an array you can add/remove elements from. 
var exampleArrList = new ArrayList(); // Create a new ArrayList. 
// Adding elements to an ArrayList ise .Add()
exampleArrList.Add(5); 
exampleArrList.Add("Shrek 5: The Search for Doney");
exampleArrList.Add(false);
exampleArrList.Add(1.25D);

// Create ArrayList with Values
var exampleArrList2 = new ArrayList()
    { 
      -10, "Last Name", "Purple", false, 25.25D, 195000, 0.0D
    }; 

// Console.WriteLine(exampleArrList[2]);
// Console.WriteLine(exampleArrList[5]);

// Inserting to a specific position in the ArrayList
// Use .Insert(index, value)
// exampleArrList.Insert(3, "Ogres are like onions.\n"); 
// exampleArrList.Insert(0, -99); 

// .Remove(value) removes the FIRST OCCURANCE of the item from the ArrayList
var newList = new ArrayList()
    {
      -10, 10, 15, -25, -10, 25, 33, -25, 40
    }; 
Console.WriteLine(newList[0]);
newList.Remove(-10); 
Console.WriteLine(newList[0]);

// Deleting based on index number. 
// .RemoveAt(value) --> deletes the item at the specified index
newList.RemoveAt(4); 

// Delete the First Item
newList.RemoveAt(0);

// Delete the Last Item
newLst.RemoveAt(newList.Length - 1); 

// Remove an entire range of elements.
// .RemoveRange(firstIndex, LastIndexToDelete)
newList.RemoveRange(3, 8)

// Shortcut to Delete from one item through end of the list. 
newList.RemoveRange(4, newList.Length - 1);

// Does the ArrayList contain value. 
// .Contains(value) returns true if the list has that value, false otherwise. 
var playerInventory = new ArrayList()
    {
      "Sword", "Shield", "Bazooka", "1-Up Power-Up", "Death Notebook", "Potata"
    }; 

Console.WriteLine(playerInventory.Contains("Fishing Pole")); 
Console.WriteLine(playerInventory.Contains("Sword"));
if (playerInventory.Contains("Blue Key"))
{
  // Do Something
}



}
{

  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENTED FROM THE LEFT
} // DO NOT DELETE EVER, SHOULD ALWAYS TOUCH THE LEFT MARGIN 
  

    
