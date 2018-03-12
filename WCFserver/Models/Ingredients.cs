namespace WCFserver
{
    using System.Collections.Generic;

    public class Ingredients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual UnitsOfMeasurement UnitsOfMeasurements { get; set; }
        public virtual ICollection<ReadyMeals> ReadyMeals { get; set; }
        public float PriceForItem { get; set; }
        public virtual Category Category{get;set;}
        public virtual ProductsType ProductsType { get; set; }

    }
}