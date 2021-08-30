using System;
using System.Collections.Generic;

namespace princess_brides
{
    class Program
    {
        static void Main(string [] args)
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
            Console.WriteLine(HeistTeam.TeamMembers.Count);
            
            foreach (Member member in HeistTeam.TeamMembers)
            {
                Console.WriteLine(member.DisplayMember(member));
            }
        }
    }
}
