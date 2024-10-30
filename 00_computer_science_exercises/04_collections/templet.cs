//Data Types and Operators, Semaia Encalade, v0.0
using System; 
using System.Ling; 
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
  string [] breakFastFoods = {"Bacon", "Waffals", "Sausage", "Eggs" "Grits"};
  int[] testScore = {0, 25, 15, 75, 99};
  double[]GPA = {0.27D, 1,99D, 4.02D, 0.0D, 3.25D};

  // Print Array Contents -- All Elements on Single Line
  Console.WriteLine("The elements of each array are:\n"); 
  Console.WriteLine("breakFastFoods: \n" + String.Join(",", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen 

  // Print Array Contents -- All Elements on Single Line
  Console.WriteLine("The elements of each array are:\n"); 
  Console.WriteLine("breakFastFoods: \n" + String.Join("\n", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen

  // How long is my array? BETERNIMING ARRAY LENGTH
  Console.WriteLine("The length of the breakFastFoods array is: " + breakfastFoods.Length);
  // Length is known as a PROPERTY of the array.

  // Accesing Elements in the array with the index
  Console.WriteLine("The first element of the breakFastFoods array is: " + breakfastFoods[0]);
  // PRINT THE 2nd ELEMENT OF THE testScores array
  // PRINT THE 3rd ELEMENT OF THE GPA array







  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENTED FROM THE LEFT
} // DO NOT DELETE EVER, SHOULD ALWAYS TOUCH THE LEFT MARGIN 
  

    
