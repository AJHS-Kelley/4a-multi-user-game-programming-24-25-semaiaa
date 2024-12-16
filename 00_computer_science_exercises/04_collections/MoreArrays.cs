using System; 
using System.Linq; 
using System.Collections;

class MoreArrays {
  static void Main() { // DO NOT DELETE

  string[] colors = {"Garnet", "Gold", "Purple", "Teal", "Fuschia"};
    // LOOPING THROUGH ARRAYS -- The old way.
  for (int i = 0; i < colors.Length; i++)
  {
    Console.WriteLine(colors[i]); 
  }

  // Looping through arrays -- the new hotnesssssss.
  foreach (string i in colors)
  {
    Console.WriteLine(i); 
  }

  // Looping through Array Practice 
  int[] numbers = {-10, 25, -345, 45, 9999, 1, 0, 68, 538, -99999};
  // Your loop should iterate through the entire array. 
  // Print the value on the screen 
  // If the number is even, print that to the screen
  // If the number is odd, print that to the screen

  foreach (string i in numbers)
  {
    Console.WriteLine(i); 
    if (i % 2 == 0) // MODULUS DIVIDES AND RETURNS THE REMAINDER.
    {
      Console.WriteLine("This number is even.\n");
    }
    else // IT MUST BE ODD
    {
      Console.WriteLine("This number is even.  Just like you,.\n");
    }
  }

  // MULTIDIMENSIONAL ARRAS
  // This class will only use 2 Dimentional Arrays. 
  int[,] nums { {2, 4, 6}, {-1, 0, 1} }; 
   
  // ACCESSING ELEMENTS IN 2D ARRAYS
  Console.WriteLine(nums[0, 1]);
  Console.WriteLine(nums[1, 1]);

  // CHANGING ELEMN=ENTS IN 2D ARRAYS
  nums[1, 2] = 9001; 
  // CHANGE ANY ELEMENT FROM THE FIRST ARRAY
  nums[0, 2] = 502;

  // LOOPING THROUGH 2D ARRAYS -- EASY MODE
  foreach (int i in nums)
  {
    Console.WriteLine(i);
  }

  // LOOPING THROUGH 2D ARRAYS -- HARD MODE
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for(int j = 0; j < nums.GetLength(1); j++)
    {
      Console.WriteLine(nums[i, j]); 
    }
  }






  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENTED FROM THE LEFT
} // DO NOT DELETE EVER, SHOULD ALWAYS TOUCH THE LEFT MARGIN 
  

    
