    using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFserver
{

    public class Ingredients
    {
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        public virtual UnitsOfMeasurement UnitsOfMeasurements { get; set; }
        public virtual ICollection<ReadyMeals> ReadyMeals { get; set; }
        [DataMember]
        public double PriceForItem { get; set; }
        public virtual Category Category{get;set;}
        public virtual ICollection<ProductsType> ProductTypes { get; set; }

    }
}