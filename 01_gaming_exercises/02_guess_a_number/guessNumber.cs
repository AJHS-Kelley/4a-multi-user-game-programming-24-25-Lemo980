//Eliot Blanton, Guess A Number, v1, 9/6/24
using System;

class Template {
    static void Main(){

        int numGuesses = 0;
        int maxGuesses = 5;
        int guess;
        //Generate the secret number here
        Random rnd = new Random();
        int secretNum = rnd.Next(100); // generates from 0 to 100
        //int secretNum = rnd.Next(25, 1000); // generates from 25 to 1000


        //while loop
        while(numGuesses < maxGuesses)
        {
            //Allow user to guess number
            //Console.WriteLine("Your secret number is " + secretNum);
            Console.WriteLine("Please insert a integer between 0 and 100 as a guess\n");
            guess = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(guess);

            //+1 to number of guesses made
            numGuesses++;
            //Compare guess to random number.
            //If match, print win, if greater or less, give hint
            if(guess < secretNum)
            {
                Console.WriteLine("Your guess is too low\n");
            }
            else if(guess > secretNum)
            {
                Console.WriteLine("Your guess is too high\n");
            }
            else 
            {
                Console.WriteLine("Congradulations! Your guess is correct!\n");
                break;
            }
            
            //Check if the number of guesses made exceeds the max guesses
            if(numGuesses >= maxGuesses)
            {
                Console.WriteLine("You Lose. \nYou are a failure.");
            }

            //If max guesses exceeded, print lose game message, if not, allow for another guess
        }
    }
}