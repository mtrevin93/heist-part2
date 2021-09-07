using System;

namespace Heist

{
    public class LockSpecialist : Robber, IRobber
    {
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - 50;
            if (bank.VaultScore <= 0) {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
            else {
                Console.WriteLine($"{Name} is hacking the alarm system. Decreased security 50 points!");
            }
        }
        public int PercentageCut { get; set; }
    }   
}