using System;

namespace Heist

{
    public class Muscle : Robber, IRobber
    {
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - 50;
            if (bank.SecurityGuardScore <= 0) {
                Console.WriteLine($"{Name} beat up all of the security guards!");
            }
            else {
                Console.WriteLine($"{Name} is taking care of the security guards! Decreased security by 50 points.");
            }
        }
        public int PercentageCut { get; set; }
    }   
}