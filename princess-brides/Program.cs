using System;

namespace princess_brides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");

            Console.WriteLine("Please enter your team members name!");
            Member member = new Member();

            member.Name = Console.ReadLine();

            Console.WriteLine("Please enter their skill level!");
            member.SkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter their courage factor!");
            member.CourageFactor = float.Parse(Console.ReadLine());

            Console.WriteLine(member.DisplayMember(member));

            
        }
    }
}
