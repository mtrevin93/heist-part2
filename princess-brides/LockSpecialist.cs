using System;

namespace Heist

{
    public class LockSpecialist : Robber, IRobber
    {
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - 50;
            if (bank.VaultScore <= 0) {
                Console.WriteLine($"{Name} has cracked the vault code!");
            }
            else {
                Console.WriteLine($"{Name} is cracking the vault code! Decreased security by 50 points.");
            }
        }
        public int PercentageCut { get; set; }
        public override string ToString()
        {
            return (
                $"Name - {Name}, Specialty - Lock Specialist, Skill Level - {SkillLevel},  Cut - {PercentageCut}%"
                );
        }
    }   
}