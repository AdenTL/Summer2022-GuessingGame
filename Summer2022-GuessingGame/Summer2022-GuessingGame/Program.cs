﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Adens and Thomas's Guessing Game!");
int num = 9;
int min = 0;
int max = 10;

Console.WriteLine("Guess a number between 1 - 10!: ");



//if (userInput == num)
//{
//    Console.WriteLine("You guess the correct number.");
//}
//else if (userInput > max || userInput < min)
//{
//    Console.WriteLine("Please enter a number within the range 1 - 10.");
//}
//else
//{
//    Console.WriteLine("You chose the wrong number!");
//}

//while(userInput <= max)
//{
//    Console.WriteLine("Please guess a number!");
//    Console.ReadLine();

//    if (userInput == num)
//        Console.WriteLine(num + " was the correct answer!");
//    else
//    {
//        Console.WriteLine("Try again");
//        Console.ReadLine();
//    }
//    else if
//}
int tries = 0;
while(tries < 3)
{
    int userInput = Int32.Parse(Console.ReadLine());

    if (userInput == num)
    {
        Console.WriteLine("You guessed the correct number.");
        tries = 3;

    }
    else if (userInput > max || userInput < min)
    {
        Console.WriteLine("Please enter a number within the range 1 - 10.");
        tries++;
        Console.WriteLine("Guess a number again!");
    }
    else
    {
        Console.WriteLine("You chose the wrong number!");
        tries++;
        Console.WriteLine("Guess a number again!");
    }


}
<<<<<<< HEAD








//switch (userInput)
//{
//    case 0: Console.WriteLine("Please enter your first number");
//        break;

//    case 1:
//        Console.WriteLine("Please enter your second number");
//        break;

//    case 2:
//        Console.WriteLine("Please enter your third number");
//        break;
//    default: Console.WriteLine("Please enter a value from 1-10");
//        break;

//}

=======
else if (userInput > 10 || userInput < 0) 
{
Console.WriteLine("please enter a number within the range 1-10");
}
else 
{
    Console.WriteLine("You chose the wrong number");
}
>>>>>>> 2fd6b60104ecead96d483c98066f80a31efc8acf
