using System;

namespace _2_RCPGame
{
    class Program
    {
        enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2 사이의 랜덤값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case (int)Choice.Scissors:
                Console.WriteLine("Your choice is 가위");
                break;
                case (int)Choice.Rock:
                Console.WriteLine("Your choice is 바위");
                break;
                case (int)Choice.Paper:
                Console.WriteLine("Your choice is 보");
                break;
            }

            switch(aiChoice)
            {
                case (int)Choice.Scissors:
                Console.WriteLine("Computer choice is 가위");
                break;
                case (int)Choice.Rock:
                Console.WriteLine("Computer choice is 바위");
                break;
                case (int)Choice.Paper:
                Console.WriteLine("Computer choice is 보");
                break;
            }

            // 승리 무승부 패배
            if(choice > aiChoice)
            {
                Console.WriteLine("You Win");
            }
            else if(choice < aiChoice)
            {
                Console.WriteLine("Computer Win");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
