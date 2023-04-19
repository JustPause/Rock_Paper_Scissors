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
            bool Play = true;

            while (Play)
            {
                Score1 = 0; Score2 = 0;
                while (Score1 < 3 && Score2 < 3)
                {

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
                            System.Console.WriteLine("Player = {0}, AI = {1}", Score1, Score2);
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
                            System.Console.WriteLine("Player = {0}, AI = {1}", Score1, Score2);
                            break;

                        case 3:

                            Input2Player = Choses[RandomInt - 1];

                            System.Console.WriteLine("The AI has chosen a {0}", Choses[RandomInt - 1]);

                            if (Input1Player == Choses[RandomInt - 1])
                            {
                                System.Console.WriteLine("GG. Is a Draw");
                            }
                            else if (Input1Player == Choses[RandomInt - 3])
                            {
                                System.Console.WriteLine("Player wins!!");
                                Score1++;
                            }
                            else if (Input1Player == Choses[RandomInt - 2])
                            {
                                System.Console.WriteLine("AI wins!!");
                                Score2++;
                            }
                            System.Console.WriteLine("Player = {0}, AI = {1}", Score1, Score2);
                            break;

                        default:
                            System.Console.WriteLine("Somefing went worong.");
                            break;
                    }
                }
                if (Score1 == 3)
                {
                    System.Console.WriteLine("Player has won. Nice");
                }
                else if (Score2 == 3)
                {
                    System.Console.WriteLine("AI has won. Bad");
                }
                else
                {

                }

                while (true)
                {
                    System.Console.WriteLine("Play again? [Y/n]");

                    string PlayGame = "y";
                    PlayGame = System.Console.ReadLine();
                    PlayGame = PlayGame.ToUpper();
                    if (PlayGame == "Y")
                    {
                        Play = true;
                        break;
                    }
                    else if (PlayGame == "N")
                    {
                        Play = false;
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Wrong input");
                    }
                }
            }
        }
    }
}