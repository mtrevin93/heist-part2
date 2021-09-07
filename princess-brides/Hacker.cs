using System;

namespace Heist

{
    public class Hacker : Robber, IRobber
    {
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
            if (bank.AlarmScore <= 0) {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
            else {
                Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points!");
            }
        }
        public double PercentageCut { get; set; }
        public override string ToString()
        {
            return (
                $"Name - {Name}, Specialty - Hacker, Skill Level - {SkillLevel},  Cut - {PercentageCut*100}%"
                );
        }
    }   
}