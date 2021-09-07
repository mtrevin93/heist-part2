using System;
using System.Collections.Generic;

namespace Heist
{
    public class Team
    {
        public List<Robber> TeamMembers {get; set;} 
        
        public Team()
        {
           TeamMembers = new List<Robber>();   
        }
    }
}