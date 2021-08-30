using System;
using System.Collections.Generic;

namespace princess_brides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");

            Team HeistTeam = new Team();

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

                    if (member.Name != "")
                    {
                        HeistTeam.TeamMembers.Add(member);

                    }
                }
            }
            // Console.WriteLine(HeistTeam.TeamMembers.Count);
            //Prompt user for number of trial runs
            Console.WriteLine("Number of trial runs?");
            int numRuns = int.Parse(Console.ReadLine());
            int Total = 0;
            foreach (Member member in HeistTeam.TeamMembers)
            {
                Total += member.SkillLevel;
            }
            Bank bank = new Bank();
            for (int i = 0; i < numRuns; i++)
            {
            int thisRunsDifficulty = bank.newLuckValue();
            if (Total >= thisRunsDifficulty)
            {
                Console.WriteLine($"The team's combined skill level: {Total}. The bank's difficulty level: {thisRunsDifficulty}.");
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine($"The team's combined skill level: {Total}. The bank's difficulty level: {thisRunsDifficulty}.");
                Console.WriteLine("Failure!");
            }
            }
        }
    }
}

// Phase Six
// The program should be updated to...

// At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// At the end of the program, display a report showing the number of successful runs and the number of failed runs.
