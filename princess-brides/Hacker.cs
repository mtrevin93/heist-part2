using System;

namespace Heist

{
    public class Hacker : Robber, IRobber
    {
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - 50;
            if (bank.AlarmScore <= 0) {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
            else {
                Console.WriteLine($"{Name} is hacking the alarm system. Decreased security 50 points!");
            }
        }
        public int PercentageCut { get; set; }
    }   
}