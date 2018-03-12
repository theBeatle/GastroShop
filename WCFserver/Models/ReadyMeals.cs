namespace WCFserver
{
    using System.Collections.Generic;

    public class ReadyMeals
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Ingredients Ingredients { get; set; }
        public string Description { get; set; }
        public float Raiting { get; set; }
        public float Size { get; set; }
        public virtual ICollection<Blogs> Blogs { get; set; }
    }
}