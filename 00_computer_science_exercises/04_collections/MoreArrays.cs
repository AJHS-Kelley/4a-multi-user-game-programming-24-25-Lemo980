using System;
using System.Linq;
using System.Collections;

class MoreArrays {
    static void Main(){
/*
        string[] colors = {"red", "yellow", "green", "blue", "brown", "orange"};
        //Looping through arrays -- the old way
        for(int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }

        //Looping through arrays -- the new way
        foreach (string i in colors)
        {
            Console.WriteLine(i);
        }

        //Looping through array practice
        int[] numbers = {100, 20000, 333, 44435, 5754, 6234, 5667, 8456, 77, 90754,};
        foreach (int i in numbers)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " Is even \n");
            }
            else
            {
                Console.WriteLine(i + " Is odd\n");
            }
        }
*/
        //MULTI-DIMENSIONAL ARRAYS
        //this class will only deal with 2 dimensional arrays

        int[,] nums = {{1, 2, 3}, {-1, -2, -3}};

        //ACCESSING ELEMENTS IN 2D ARRAYS
        //Console.WriteLine(nums[0, 1]);
        //Console.WriteLine(nums[1, 1]);

        //CHANGING ELEMENTS
        //nums[1, 2] = 9001;
        //nums[0, 0] = 42;

        //Looping through a 2D array -- easy
        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }

        //Looping through a 2D array -- hard
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.WriteLine(nums[i, j]);
            }
        }




    }//DO NOT DELETE, 3 SPACES INDENTED
}//DO NOT DELETE