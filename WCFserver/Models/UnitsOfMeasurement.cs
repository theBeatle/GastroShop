namespace WCFserver
{
    using System.Collections.Generic;

    public class UnitsOfMeasurement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public virtual ICollection<Ingredients> Ingredients{ get; set; }

    }
}