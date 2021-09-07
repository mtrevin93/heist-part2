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
                    Console.WriteLine("Please enter your team members name!");
                    Member member = new Member();

                    member.Name = Console.ReadLine();
                    if (member.Name == "")
                    {
                        break;
                    }

                    Console.WriteLine("Please enter their skill level!");
                    member.SkillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter their courage factor!");
                    member.CourageFactor = float.Parse(Console.ReadLine());

                }
            }
            // Console.WriteLine(HeistTeam.TeamMembers.Count);
            //Prompt user for number of trial runs
            Console.WriteLine("Number of trial runs?");
            int numRuns = int.Parse(Console.ReadLine());
            int Total = 0;
            int successes = 0;
            int failures = 0;
            foreach (Member member in HeistTeam.TeamMembers)
            {
                Total += member.SkillLevel;
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
