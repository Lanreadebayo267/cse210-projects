// EXCEEDS REQUIREMENTS: Leveling system + badge system implemented

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string input = "";

        while (input != "6")
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save/Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.DisplayGoals(); break;
                case "3": manager.RecordEvent(); break;
                case "4": manager.ShowScore(); break;
                case "5":
                    Console.Write("Save or Load? (s/l): ");
                    string mode = Console.ReadLine();
                    Console.Write("Filename: ");
                    string file = Console.ReadLine();
                    if (mode == "s") manager.SaveGoals(file);
                    else manager.LoadGoals(file);
                    break;
            }
        }

        Console.WriteLine("Thanks for playing Eternal Quest!");
    }
}
