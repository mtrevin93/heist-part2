using System;
using System.Linq;
using System.Collections.Generic;

namespace Heist
{
    public class Bank
    {
        public int difficultyLevel { get; set; }

        public int newLuckValue()
        {
            return  difficultyLevel + new Random().Next(-10, 11);
        }
        public Bank()
        {
            difficultyLevel = 100;
            CashOnHand = new Random().Next(0, 101);
            VaultScore = new Random().Next(0, 101);
            SecurityGuardScore = new Random().Next(0, 101);
            CashOnHand = new Random().Next(50000, 1000001);
        }

        public void ReconReport()
        {
        List<int> securityScores = new List<int>() { AlarmScore, VaultScore, SecurityGuardScore };
        if (AlarmScore == securityScores.Max()) {
            Console.WriteLine("The Security System is the most secure.");
        }
        if (VaultScore == securityScores.Max()) {
            Console.WriteLine("The Vault is the most secure.");
        }
        if (SecurityGuardScore == securityScores.Max()) {
            Console.WriteLine("The Security Guards look pretty tough.");
        }
        if (AlarmScore == securityScores.Min()) {
            Console.WriteLine("The Security System looks pretty weak.");
        }
        if (VaultScore == securityScores.Min()) {
            Console.WriteLine("The Vault looks easy to crack.");
        }
        if (SecurityGuardScore == securityScores.Min()) {
            Console.WriteLine("The Security Guards don't look so tough.");
        }
        }
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure 
        {
            get { 
                if (AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0){
                return true;
                } 
                else {
                return false;
                }
            }
        }
    }

}