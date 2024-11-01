//Collections Example, Eliot Blanton, v2.0
using System;
using System.Linq;
using System.Collections;

class Collections {
    static void Main(){

        /*
        ARRAYS
        In C# a collection is known as an ARRAY
        -- Each item in the array is know as an element
        -- The number of elements in the array cannot be changed
        -- Contents of each element can change
        -- Arrays are ordered, meaning that each item has a fixed position
        -- The position of an element is called the index
        -- The index of the first element is ZERO
        */

        //DECLARING AND DEFINING AN ARRAY
        string[] breakfastFoods = {"Eggs", " Waffle", " Pancake", " Bacon", " Hashbrowns"};
        int[] testScores = {89, 12, 32, 99, 100};
        double[] GPAs = {0.01D, 2.6D, 3.5D, 3.0D, 4.0D};
/* ------------------------------------------------------------------
        //Print Array Contents -- All elements on a single line
        Console.WriteLine("The elements of each array are:\n");
        Console.WriteLine("breakfastFoods: \n" + String.Join(",", breakfastFoods));
        Console.WriteLine(); // print an empty line to the screen

        //print array elements on seperate lines
        Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
        Console.WriteLine(); // print an empty line to the screen

        Console.WriteLine("GPAs: \n" + String.Join("\n", GPAs));
        Console.WriteLine(); // print an empty line to the screen

        //How long is my array?   DETERMINING ARRAY LENGTH
        Console.WriteLine("The length of the breakfast foods array is: " + breakfastFoods.Length);
        //.Length is known as a property of the array
        Console.WriteLine("The length of the GPAs array is: " + GPAs.Length);

        //Accessing elements in the array within the index
        Console.WriteLine("The first element in the array breakfastFoods is: " + breakfastFoods[0]);
        // print the second element of the testScores array
        Console.WriteLine("The second element in the array testScores is: " + testScores[1]);
        // print the third element of the GPAs array
        Console.WriteLine("The third element in the array GPAs is: " + GPAs[2]);

        //Shortcut to access last item in an array
        Console.WriteLine("The last element of breakfast foods is " + breakfastFoods[breakfastFoods.Length - 1]);
        Console.WriteLine("The last element of GPAs is " + GPAs[GPAs.Length - 1]);

        //Changing elements in an array
        breakfastFoods[4] = " Rattlesnake spine";
        GPAs[4] = 3.26D;
        testScores[3] = 95;

        Console.WriteLine("The elements of each array are:\n");
        Console.WriteLine("breakfastFoods: \n" + String.Join(",", breakfastFoods));
        Console.WriteLine();
--------------------------------------------------------------------------*/


        //Common Errors with arrays
        //Console.WriteLine(breakfastFoods[99]);  //Index out of bounds -- Accessing index that does not exist in the array
        //testScores[0] = "99"; // Cannot implicitly change (insert datatype) to (insert different datatype) -- Attempting to put a element of one datatype into an array containing elements of a different datatype

        //Common array methods -- Ways to work with array data
        //sorting an array
        int[] intArr = {66, 1, 85, 234, 7789, 232, 67684, 12, 8, -33001};
        string[] zooAnimals = {"orangutan", "leemur", "iguana", "leopard", "rat", "tapir", "frog", "eagle", "crow", "isopod"};

        Console.WriteLine("The integer array is: \n" + String.Join(", ", intArr));
        Console.WriteLine("The zooAnimals array is: \n" + String.Join(", ", zooAnimals));

        Array.Sort(intArr);
        Array.Sort(zooAnimals);

        Console.WriteLine("The integer array is: \n" + String.Join(", ", intArr));
        Console.WriteLine("The zooAnimals array is: \n" + String.Join(", ", zooAnimals));

        //Finding the MIN, MAX, and SUM of numerical arrays
        Console.WriteLine("The MINIMUM value for intArr is: " + intArr.Min());
        Console.WriteLine("The MAXIMUM value for intArr is: " + intArr.Max());
        Console.WriteLine("The SUM value for intArr is: " + intArr.Sum());
    }//DO NOT DELETE, 3 SPACES INDENTED
}//DO NOT DELETE
