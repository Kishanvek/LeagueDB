using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueDB.Models
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; }
        public int Gold { get; set; }
        public string Stats { get; set; }
        public virtual ICollection<Build> Builds { get; set; }
    }
}