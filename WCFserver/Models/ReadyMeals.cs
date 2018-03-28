    using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFserver
{

    public class ReadyMeals
    {
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        public virtual ICollection<Ingredients> Ingredients { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double Raiting { get; set; }
        [DataMember]
        public string Size { get; set; }
        public virtual ICollection<Blogs> Blogs { get; set; }
        public string MealPicUrl { get; set; }
    }
}