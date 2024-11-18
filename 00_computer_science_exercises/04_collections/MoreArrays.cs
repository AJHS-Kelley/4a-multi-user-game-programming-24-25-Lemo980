using System;
using System.Linq;
using System.Collections;

class MoreArrays {
    static void Main(){

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
        int[] numbers = {100, 20000, 333, 44435, 5754, 6234, 5667, 8456, 77, 90754, };
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



    }//DO NOT DELETE, 3 SPACES INDENTED
}//DO NOT DELETE