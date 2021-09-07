using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    public class Team
    {
        public List<IRobber> TeamMembers {get; set;} 
        
        public Team()
        {
           TeamMembers = new List<IRobber>();   
        }
        public int TotalPercentageCut()
        {
            IEnumerable<int> totalCutIE = TeamMembers.Select(m => m.PercentageCut);
            return totalCutIE.Sum();
        }
    }
}