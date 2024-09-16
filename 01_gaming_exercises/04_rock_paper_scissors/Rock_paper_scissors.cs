using System;

class Template {
    static void Main(){
    
    string CPUchoice = "";
    string userChoice = "";
    string userName = "";
    int playerPts = 0;
    int compPts = 0;

    Console.WriteLine("To start, input your name and press ENTER.");
    userName = Console.ReadLine();
    Console.WriteLine("Welcome to rock paper scissors " + userName + "!\n");
    Console.WriteLine("In this game two players (you and the CPU) choose rock, paper, or scissors.\nRock beats scissors, scissors beats paper, paper beats rock, and each round win will give you one point.\nFirst to 5 points wins the game!");

    Console.WriteLine("Input rock, paper, or scissors");
    userChoice = Console.ReadLine().ToLower();
    //Console.WriteLine(userChoice);


    Random rnd = new Random();
    int Rand123 = rnd.Next(1, 4);
    //Console.WriteLine(Rand123);

    if(Rand123 == 1)
    {
        CPUchoice = "rock";
    }
    else if(Rand123 == 2)
    {
        CPUchoice = "paper";
    }
    else
    {
        CPUchoice = "scissors";
    }
    //Console.WriteLine(CPUchoice);

    //If there is a draw
    if(CPUchoice == userChoice)
    {
        Console.WriteLine("Draw. No points have been awarded");
    }

    //Checks for what the CPU chose then compares it to user choice and adds points accordingly
    if(CPUchoice == "rock")
    {
        if(userChoice == "paper")
        {
            Console.WriteLine("Congrats " + userName + " you earned a point");
            playerPts += 1;
        }

        if(userChoice == "scissors")
        {
            Console.WriteLine("You Lost! The Cpu gains a point");
            compPts += 1;
        }
    }

    else if(CPUchoice == "paper")
    {
        if(userChoice == "scissors")
        {
            Console.WriteLine("Congrats " + userName + " you earned a point");
            playerPts += 1;
        }

        if(userChoice == "rock")
        {
            Console.WriteLine("You Lost! The Cpu gains a point");
            compPts += 1;
        }
    }

    else if(CPUchoice == "scissors")
    {
        if(userChoice == "rock")
        {
            Console.WriteLine("Congrats " + userName + " you earned a point");
            playerPts += 1;
        }

        if(userChoice == "paper")
        {
            Console.WriteLine("You Lost! The Cpu gains a point");
            compPts += 1;
        }
    }



































    }
}