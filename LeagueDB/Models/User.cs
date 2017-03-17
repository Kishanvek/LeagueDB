using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueDB.Models
{
    public class User
    {
        public string ID { get; set; }
        public virtual ICollection<Build> Builds { get; set; }
    }
}