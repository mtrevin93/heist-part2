using System;
using System.Collections.Generic;

namespace princess_brides
{
    public class Team
    {
        public List<Member> TeamMembers {get; set;} 
        
        public Team()
        {
           TeamMembers = new List<Member>();   
        }
    }
}