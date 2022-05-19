// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Adens and Thomas's Guessing Game!");
int num = 9;


Console.WriteLine("Guess a number between 1 - 10!: ");


int userInput = Int32.Parse(Console.ReadLine());
if (userInput == num)
{
    Console.WriteLine("You guess the correct number");
}
