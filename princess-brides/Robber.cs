using System;

namespace Heist
{
    public class Robber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public Robber() {}

        public override string ToString()
        {
            return (
                $"Name - {Name}, Skill Level - {SkillLevel}"
            );
        }
    }
}