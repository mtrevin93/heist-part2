using System;

namespace Heist

{
    public class Muscle : Robber, IRobber
    {
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            if (bank.SecurityGuardScore <= 0) {
                Console.WriteLine($"{Name} beat up all of the security guards!");
            }
            else {
                Console.WriteLine($"{Name} is taking care of the security guards! Decreased security by {SkillLevel} points.");
            }
        }
        public double PercentageCut { get; set; }
        public override string ToString()
        {
            return (
                $"Name - {Name}, Specialty - Muscle, Skill Level - {SkillLevel},  Cut - {PercentageCut*100}%"
                );
        }
    }   
}