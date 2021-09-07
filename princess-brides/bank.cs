using System;

namespace princess_brides
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
        }
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure 
        {
            get { 
                if (CashOnHand > 0 || AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0){
                return true;
                } 
                else {
                return false;
                }
            }
        }
    }

}