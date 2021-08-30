using System;

namespace princess_brides
{
    public class Bank
    {
        public int difficultyLevel { get; set; }

        public int newLuckValue()
        {
            return  difficultyLevel + new Random().Next(-10, 10);
        }
        public Bank()
        {
            difficultyLevel = 100;
        }
    }

}