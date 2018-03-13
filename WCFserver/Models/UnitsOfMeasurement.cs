    using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFserver
{

    public class UnitsOfMeasurement
    {
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Abbreviation { get; set; }
        public virtual ICollection<Ingredients> Ingredients{ get; set; }

    }
}