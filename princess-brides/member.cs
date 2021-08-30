using System;

namespace princess_brides
{
    public class Member
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public float CourageFactor { get; set; }

        public Member()
        {

        }

        public string DisplayMember(Member member)
        {
            return (
                $"Name - {member.Name}, Skill Level - {member.SkillLevel},  Courage Factor - {member.CourageFactor}"
                    );
        }
    }
}