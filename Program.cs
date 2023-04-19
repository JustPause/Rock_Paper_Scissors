namespace RockPaperScissors
{
    class TheProgram
    {
        static void Main(string[] arg)
        {
            string Input1Player, Input2Player;
            int RandomInt;
            int Score1 = 0;
            int Score2 = 0;

            System.Console.Write("Choose, A move. Rock || Paper || Scissors: ");
            Input1Player = Console.ReadLine();
            Input1Player = Input1Player.ToUpper();

            System.Random GetRand = new System.Random();

            RandomInt = GetRand.Next(1, 4);

            string[] Choses = new string[] { "ROCK", "PAPER", "SCISSORS" };



            switch (RandomInt)
            {
                case 1:
                    Input2Player = Choses[RandomInt - 1];

                    System.Console.WriteLine("The AI has chosen a {0}", Choses[RandomInt - 1]);

                    if (Input1Player == Choses[RandomInt - 1])
                    {
                        System.Console.WriteLine("GG. Is a Draw");
                    }
                    else if (Input1Player == Choses[RandomInt])
                    {
                        System.Console.WriteLine("Player wins!!");
                        Score1++;
                    }
                    else if (Input1Player == Choses[RandomInt + 1])
                    {
                        System.Console.WriteLine("AI wins!!");
                        Score2++;
                    }
                    break;

                case 2:
                    Input2Player = Choses[RandomInt - 1];

                    System.Console.WriteLine("The AI has chosen a {0}", Choses[RandomInt - 1]);

                    if (Input1Player == Choses[RandomInt - 1])
                    {
                        System.Console.WriteLine("GG. Is a Draw");
                    }
                    else if (Input1Player == Choses[RandomInt])
                    {
                        System.Console.WriteLine("Player wins!!");
                        Score1++;
                    }
                    else if (Input1Player == Choses[RandomInt - 2])
                    {
                        System.Console.WriteLine("AI wins!!");
                        Score2++;
                    }
                    break;

                case 3:

                    Input2Player = Choses[RandomInt - 1];

                    System.Console.WriteLine("The AI has chosen a {0}", Choses[RandomInt - 1]);

                    if (Input1Player == Choses[RandomInt - 1])
                    {
                        System.Console.WriteLine("GG. Is a Draw");
                    }
                    else if (Input1Player == Choses[RandomInt - 2])
                    {
                        System.Console.WriteLine("Player wins!!");
                        Score1++;
                    }
                    else if (Input1Player == Choses[RandomInt])
                    {
                        System.Console.WriteLine("AI wins!!");
                        Score2++;
                    }
                    break;

                default:
                    System.Console.WriteLine("Somefing went worong.");
                    break;
            }
        }
    }
}
