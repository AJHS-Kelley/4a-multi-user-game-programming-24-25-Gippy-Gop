using System;
using System.Linq;
using System.Collections;
class MoreArrays {
  static void Main() { 

string[]colors = {"Garnet","Gold", "Purple","Teal", "Fuschia"};
//LOOPING THROUGH ARRAYS -- the old way.
for (int i = 0 ; i < colors.Length; i++)
{
Console.WriteLine(colors[1]);
}

//Looping through arrays -- the new hotness.
foreach (string i in colors)
{
  Console.WriteLine(i);
}

// Looping through Array Practice
int []numbers ={-10, 25, -345, 45, 9999, 1, 0, 68, 538, -9999};
//Your loop should iterate through the entire array.
for (int i = 0 ; i < numbers.Length; i++)
if (i % 2 ==0)
{
Console.WriteLine("The number is even\n");
}
else
{
  Console.WriteLine("The number is odd\n");
}

// MULTIDIMENSIONAL ARRAYS
//This class we'll only use 2 dimensional arrays
int[,] nums = { {1,2,3},{5,0,4} };


//Accessing elements in 2d arrays
Console.WriteLine(nums[0,1]);
Console.WriteLine(nums[1,1]);

//Changing elements in 2d arrays
nums[1,2] = 9001;
//Change any element from the first array 
nums[0,2] = 502;

// LOOPING Through 2d arrays -- easy way
foreach(int i in nums)
{
  Console.WriteLine(1);
}

// Looping through 2d arrays -- hard mode
for(int i = 0; i < nums.GetLength(0); i++)

{
  for(int j = 0; j < nums.GetLength(1); j++)
{
Console.WriteLine(nums[i,j]);
}
}







  }
}
