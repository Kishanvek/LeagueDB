using System;
using System.Collections.Generic;

namespace LeagueDB.Models
{
    public class Champion
    {
        public string ID { get; set; }
        public string Q { get; set; }
        public string W { get; set; }
        public string E { get; set; }
        public string R { get; set; }
        public string Passive { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
    }
}
