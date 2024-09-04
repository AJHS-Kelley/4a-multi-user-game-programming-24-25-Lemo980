using System;

class Template {
    static void Main(){

        Console.WriteLine("Input your score \n");
        int score = Convert.ToInt32(Console.ReadLine());
        int lives = 3;
        if (score <= 10000)
        {
            lives -= 1;
        }
        else if (score < 100000)
        {
            lives += 1;
        }
        else if (score >= 100000)
        {
            lives += 2;
        }
        else
        {
            Console.WriteLine("Error \n");
        }

        Console.WriteLine("You have " + lives + " lives.");
















    }
}