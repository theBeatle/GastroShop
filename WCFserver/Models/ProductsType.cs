namespace WCFserver
{
    using System.Collections.Generic;

    public class ProductsType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ingredients> Ingredients{ get; set; }
    }
}