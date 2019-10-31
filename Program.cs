using System;

namespace RPS_Game
{
  class Program
  {
    static void Main(string[] args)
    {
      bool keepPlaying = true;
      while (keepPlaying)
      {
        Console.Clear();
        Console.WriteLine("Let's play Rock, Paper, Scissors");
        Console.WriteLine();
        Console.Write("Enter you selection: ");
        bool validThrow = false;
        while (!validThrow)
        {
          string playerThrow = Console.ReadLine().ToLower();
          if (playerThrow == "rock" || playerThrow == "paper" || playerThrow == "scissors")
          {
            validThrow = true;
            Console.WriteLine(playerThrow);
            // enter random and compare logic
            Random rng = new Random();
            int throwNumOptions = 3;
            string compThrow = "";
            int compThrowNum = rng.Next(1, throwNumOptions + 1);
            switch (compThrowNum)
            {
              case 1:
                compThrow = "rock";
                break;
              case 2:
                compThrow = "paper";
                break;
              case 3:
                compThrow = "scissors";
                break;
            }
            Console.WriteLine($"Computer threw: " + compThrow);
            if (playerThrow == "rock")
            {
              if (compThrow == "rock")
              {
                Console.WriteLine("It's a draw.");
              }
              else if (compThrow == "paper")
              {
                Console.WriteLine("You lose.");
              }
              else if (compThrow == "scissors")
              {
                Console.WriteLine("you WIN!");
              }
            }
            else if (playerThrow == "paper")
            {
              if (compThrow == "rock")
              {
                Console.WriteLine("you WIN!");
              }
              else if (compThrow == "paper")
              {
                Console.WriteLine("It's a draw.");
              }
              else if (compThrow == "scissors")
              {
                Console.WriteLine("You lose.");
              }
            }
            else if (playerThrow == "scissors")
            {
              if (compThrow == "rock")
              {
                Console.WriteLine("You lose.");
              }
              else if (compThrow == "paper")
              {
                Console.WriteLine("you WIN!");
              }
              else if (compThrow == "scissors")
              {
                Console.WriteLine("It's a draw.");
              }
            }
            Console.WriteLine("");
            Console.Write("Play again? y/n ");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain == "y")
            {

            }
            else
            {
              keepPlaying = false;
              Console.Clear();
              Console.Write("Come back soon ");
            }
          }
          else if (playerThrow == "quit")
          {
            validThrow = true;
            keepPlaying = false;
            Console.Clear();
            Console.Write("Come back soon ");
          }
          else
          {
            Console.WriteLine("Invalid Selection, Valid choices: quit, rock, paper, scissors, please try again");
            Console.Write("Enter you selection: ");
          }
        }
      }
    }
  }
}