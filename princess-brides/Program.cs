using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a team
            Team Rolodex = new Team();
            Hacker Kevin = new Hacker() { Name = "Kevin", SkillLevel = 95, PercentageCut = 10 };
            Muscle Cena = new Muscle() { Name = "Cena", SkillLevel = 100, PercentageCut = 15 };
            LockSpecialist Rouge = new LockSpecialist() { Name = "Rouge", SkillLevel = 105, PercentageCut = 20 };
            Rolodex.TeamMembers.Add(Kevin);
            Rolodex.TeamMembers.Add(Cena);
            Rolodex.TeamMembers.Add(Rouge);
            // Run until user does not enter name
            while (true)
            {
                {
                    Console.WriteLine($"There are currently {Rolodex.TeamMembers.Count} robbers to choose from.");
                    for(int i = 0; i < Rolodex.TeamMembers.Count; i++){
                        Console.WriteLine($"{i+1}) {Rolodex.TeamMembers[i]}");
                    }
                    Console.WriteLine("Add robbers to the list of contacts by entering a name:");

                    string robberName = Console.ReadLine();
                    if (robberName == "")
                    {
                        break;
                    }
                    Console.WriteLine("Please pick a specialization \n 1) Hacker (Disables alarm) \n 2) Muscle (Disarms guards) \n 3) Lock Specialist (cracks vault)");
                    int memberType = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter their skill level. (1-100)");
                    int memberSkillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter their required percentage of cut (1-100).");
                    int memberCutPercentage = int.Parse(Console.ReadLine());

                    //Instantiate new member based on selected class
                    if (memberType == 1){
                        Hacker Robber = new Hacker() { Name = robberName, SkillLevel = memberSkillLevel, PercentageCut = memberCutPercentage };
                        Rolodex.TeamMembers.Add(Robber);
                    }
                    if (memberType == 2){
                        Muscle Robber = new Muscle() { Name = robberName, SkillLevel = memberSkillLevel, PercentageCut = memberCutPercentage };
                        Rolodex.TeamMembers.Add(Robber);
                    }
                    if (memberType == 3){
                        LockSpecialist Robber = new LockSpecialist() { Name = robberName, SkillLevel = memberSkillLevel, PercentageCut = memberCutPercentage };
                        Rolodex.TeamMembers.Add(Robber);
                    }
                }
            }
            //Users get report from bank, then choose which robbers to add to their crew
            Team Crew = new Team();
            Bank bank = new Bank();
            bank.ReconReport();
            while(true)
            {   
                Console.WriteLine("Your Team: ");
                foreach(IRobber robber in Crew.TeamMembers){
                    Console.WriteLine($"{robber}");
                }
                Console.WriteLine($"Your Cut: {100-Crew.TotalPercentageCut()}%");
                Console.WriteLine("-----------------------------------------------");
                if (Rolodex.TeamMembers.Count == 0){
                    break;
                }
                Console.WriteLine($"There are currently {Rolodex.TeamMembers.Count} robbers to choose from.");
                for(int i = 0; i < Rolodex.TeamMembers.Count; i++){
                    Console.WriteLine($"{i+1}) {Rolodex.TeamMembers[i]}");
                    }
                Console.WriteLine("Enter a member's number to add them to your team: ");
                string response = Console.ReadLine();
                if (response == ""){
                    break; }
                else {
                int index = int.Parse(response) - 1;
                Crew.TeamMembers.Add(Rolodex.TeamMembers[index]);
                Rolodex.TeamMembers.Remove(Rolodex.TeamMembers[index]);
                //Remove team members from possible selection if selecting them would cause percentage cut to go over 100
                foreach (IRobber robber in Rolodex.TeamMembers.ToList()) {
                    if (robber.PercentageCut + Crew.TotalPercentageCut() > 100) {
                        Rolodex.TeamMembers.Remove(robber);
                    }
                }
                }
            }

            // Prompt user for number of trial runs
            Console.WriteLine("Number of trial runs?");
            int numRuns = int.Parse(Console.ReadLine());
            int Total = 0;
            int successes = 0;
            int failures = 0;
            foreach (IRobber robber in Rolodex.TeamMembers)
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

