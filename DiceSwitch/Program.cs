namespace DiceSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generates a random number from 1 - 6
            Random rng = new Random();
            int dice = rng.Next(1,7);

            //uses a switch to check what number the dice lands on
            switch (dice)
            {
                case 1:
                    Console.WriteLine("Du slog en etter", Console.BackgroundColor = ConsoleColor.Magenta);
                    break;
                case 2:
                    Console.WriteLine("Du slog en to'er", Console.BackgroundColor = ConsoleColor.Red);
                    break;
                case 3:
                    Console.WriteLine("Du slog en tre'er", Console.BackgroundColor = ConsoleColor.Green);
                    break;
                case 4:
                    Console.WriteLine("Du slog en fire'er", Console.BackgroundColor = ConsoleColor.DarkBlue);
                    break;
                case 5:
                    Console.WriteLine("Du slog en fem'er", Console.BackgroundColor = ConsoleColor.DarkYellow);
                    break;
                case 6:
                    Console.WriteLine("Du slog en seks'er", Console.BackgroundColor = ConsoleColor.Cyan);
                    break;
                default:
                    Console.WriteLine("Fejl");
                    break;
            }
            Console.Read();
        }
    }
}