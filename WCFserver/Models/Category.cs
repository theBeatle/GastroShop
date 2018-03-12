namespace WCFserver
{
    using System.Collections.Generic;

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Ingredients> Ingredients{ get; set; }
    }
}