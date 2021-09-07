using System;
using System.Collections.Generic;

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
            List<IRobber> Rolodex = new List<IRobber>();
            Hacker Kevin = new Hacker() { Name = "Kevin", PercentageCut = 15 };
            Muscle Cena = new Muscle() { Name = "Cena", PercentageCut = 20 };
            LockSpecialist Rouge = new LockSpecialist() { Name = "Rouge", PercentageCut = 25 };
            Rolodex.Add(Kevin);
            Rolodex.Add(Cena);
            Rolodex.Add(Rouge);
            // Run until user does not enter name
            while (true)
            {
                {
                    Console.WriteLine($"There are currently {Rolodex.Count} robbers in this heist.");
                    Console.WriteLine("Please enter your team member's name!");

                    string robberName = Console.ReadLine();
                    if (robberName == "")
                    {
                        break;
                    }
                    Console.WriteLine("Please pick a specialization \n 1) Hacker (Disables alarm) \n 2) Muscle (Disarms guards) \n 3) Lock Specialist (cracks vault)");
                    int memberType = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter their skill level!");
                    int memberSkillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter their courage factor!");
                    float memberCourageFactor = float.Parse(Console.ReadLine());

                    //Instantiate new member based on selected class
                    if (memberType == 1){
                        Hacker Robber = new Hacker() { Name = robberName, SkillLevel = memberSkillLevel, CourageFactor = memberCourageFactor };
                        Rolodex.Add(Robber);
                    }
                    if (memberType == 2){
                        Muscle Robber = new Muscle() { Name = robberName, SkillLevel = memberSkillLevel, CourageFactor = memberCourageFactor };
                        Rolodex.Add(Robber);
                    }
                    if (memberType == 3){
                        LockSpecialist Robber = new LockSpecialist() { Name = robberName, SkillLevel = memberSkillLevel, CourageFactor = memberCourageFactor };
                        Rolodex.Add(Robber);
                    }
                }
            }
            Console.WriteLine(Rolodex.Count);
            // Prompt user for number of trial runs
            Console.WriteLine("Number of trial runs?");
            int numRuns = int.Parse(Console.ReadLine());
            int Total = 0;
            int successes = 0;
            int failures = 0;
            foreach (IRobber robber in Rolodex)
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
