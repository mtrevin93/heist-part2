using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new bank
            Bank bank = new Bank();
            Console.WriteLine("Bank Difficulty Level: ");
            bank.difficultyLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine(bank.IsSecure);
            //Create a team
            Team Rolodex = new Team();
            Hacker Kevin = new Hacker() { Name = "Kevin", PercentageCut = 15 };
            Muscle Cena = new Muscle() { Name = "Cena", PercentageCut = 20 };
            LockSpecialist Rouge = new LockSpecialist() { Name = "Rouge", PercentageCut = 25 };
            //Run until user does not enter name
            // while (true)
            // {
            //     {
            //         Console.WriteLine("Please enter your team Robbers name!");
            //         Robber robber = new Robber();

            //         robber.Name = Console.ReadLine();
            //         if (robber.Name == "")
            //         {
            //             break;
            //         }

            //         Console.WriteLine("Please enter their skill level!");
            //         robber.SkillLevel = int.Parse(Console.ReadLine());

            //         Console.WriteLine("Please enter their courage factor!");
            //         robber.CourageFactor = float.Parse(Console.ReadLine());
            //         Rolodex.Add(robber);
            //     }
            // }
            // Console.WriteLine(Rolodex.TeamRobbers.Count);
            //Prompt user for number of trial runs
            Console.WriteLine("Number of trial runs?");
            int numRuns = int.Parse(Console.ReadLine());
            int Total = 0;
            int successes = 0;
            int failures = 0;
            foreach (Robber robber in Rolodex.TeamMembers)
            {
                Total += robber.SkillLevel;
            }
            //Runs randomized trial runs
            for (int i = 0; i < numRuns; i++)
                {
                int thisRunsDifficulty = bank.newLuckValue();
                if (Total >= thisRunsDifficulty)
                {
                    Console.WriteLine($"The team's combined skill level: {Total}. The bank's difficulty level: {thisRunsDifficulty}.");
                    Console.WriteLine("Success!");
                    successes++;
                }
                else
                {
                    Console.WriteLine($"The team's combined skill level: {Total}. The bank's difficulty level: {thisRunsDifficulty}.");
                    Console.WriteLine("Failure!");
                    failures++;
                }
            }
             Console.WriteLine($"Successes: {successes} Failures: {failures}");
        }
    }
}
