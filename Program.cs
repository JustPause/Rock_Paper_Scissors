namespace RockPaperScissors
{
    static class Int_Int
    {
        public string Input1Player, Input2Player;
        public static int RandomInt;
        public static int Score1 = 0;
        public static int Score2 = 0;
    }
    class TheProgram
    {
        static void Main(string[] arg)
        {


            while (Int_Int.Score1 < 3 && Int_Int.Score2 < 3)
            {

            }

            System.Console.Write("Choose, A move. Rock || Paper || Scissors: ");
            Int_Int.Input1Player = Console.ReadLine();
            Int_Int.Input1Player = Int_Int.Input1Player.ToUpper();
        }

        static void F_switch()
        {
            System.Random GetRand = new System.Random();

            Int_Int.RandomInt = GetRand.Next(1, 4);

            string[] Choses = new string[] { "ROCK", "PAPER", "SCISSORS" };
            switch (Int_Int.RandomInt)
            {
                case 1:
                    Int_Int.Input2Player = Choses[Int_Int.RandomInt - 1];

                    System.Console.WriteLine("The AI has chosen a {0}", Choses[Int_Int.RandomInt - 1]);

                    if (Int_Int.Input1Player == Choses[Int_Int.RandomInt - 1])
                    {
                        System.Console.WriteLine("GG. Is a Draw");
                    }
                    else if (Int_Int.Input1Player == Choses[Int_Int.RandomInt])
                    {
                        System.Console.WriteLine("Player wins!!");
                        Int_Int.Score1++;
                    }
                    else if (Int_Int.Input1Player == Choses[Int_Int.RandomInt + 1])
                    {
                        System.Console.WriteLine("AI wins!!");
                        Int_Int.Score2++;
                    }
                    break;

                case 2:
                    Int_Int.Input2Player = Choses[Int_Int.RandomInt - 1];

                    System.Console.WriteLine("The AI has chosen a {0}", Choses[Int_Int.RandomInt - 1]);

                    if (Int_Int.Input1Player == Choses[Int_Int.RandomInt - 1])
                    {
                        System.Console.WriteLine("GG. Is a Draw");
                    }
                    else if (Int_Int.Input1Player == Choses[Int_Int.RandomInt])
                    {
                        System.Console.WriteLine("Player wins!!");
                        Int_Int.Score1++;
                    }
                    else if (Int_Int.Input1Player == Choses[Int_Int.RandomInt - 2])
                    {
                        System.Console.WriteLine("AI wins!!");
                        Int_Int.Score2++;
                    }
                    break;

                case 3:

                    Int_Int.Input2Player = Choses[Int_Int.RandomInt - 1];

                    System.Console.WriteLine("The AI has chosen a {0}", Choses[Int_Int.RandomInt - 1]);

                    if (Int_Int.Input1Player == Choses[Int_Int.RandomInt - 1])
                    {
                        System.Console.WriteLine("GG. Is a Draw");
                    }
                    else if (Int_Int.Input1Player == Choses[Int_Int.RandomInt - 2])
                    {
                        System.Console.WriteLine("Player wins!!");
                        Int_Int.Score1++;
                    }
                    else if (Int_Int.Input1Player == Choses[Int_Int.RandomInt])
                    {
                        System.Console.WriteLine("AI wins!!");
                        Int_Int.Score2++;
                    }
                    break;

                default:
                    System.Console.WriteLine("Somefing went worong.");
                    break;
            }
        }
    }
}
