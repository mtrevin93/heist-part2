using System;

namespace princess_brides
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("Bank Difficulty Level: ");
            bank.difficultyLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine(bank.IsSecure);
            Team HeistTeam = new Team();
            //Run until user does not enter name
            while (true)
            {
                {
                    Console.WriteLine("Please enter your team Robbers name!");
                    Robber robber = new Robber();

                    robber.Name = Console.ReadLine();
                    if (robber.Name == "")
                    {
                        break;
                    }

                    Console.WriteLine("Please enter their skill level!");
                    robber.SkillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter their courage factor!");
                    robber.CourageFactor = float.Parse(Console.ReadLine());

                }
            }
            // Console.WriteLine(HeistTeam.TeamRobbers.Count);
            //Prompt user for number of trial runs
            Console.WriteLine("Number of trial runs?");
            int numRuns = int.Parse(Console.ReadLine());
            int Total = 0;
            int successes = 0;
            int failures = 0;
            foreach (Robber robber in HeistTeam.TeamMembers)
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
