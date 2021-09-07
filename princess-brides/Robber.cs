using System;

namespace Heist
{
    public class Robber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public float CourageFactor { get; set; }

        public Robber()
        {

        }

        public string DisplayRobber(Robber robber)
        {
            return (
                $"Name - {robber.Name}, Skill Level - {robber.SkillLevel},  Courage Factor - {robber.CourageFactor}"
                    );
        }
    }
}