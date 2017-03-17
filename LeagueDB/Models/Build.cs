namespace LeagueDB.Models
{

    public class Build
    {
        public int ID { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }
        public string Item6 { get; set; }

        public string SumSpell1 { get; set; }
        public string SumSpell2 { get; set; }

        public virtual Item Item { get; set; }
        public virtual Champion Champion { get; set; }
    }
}