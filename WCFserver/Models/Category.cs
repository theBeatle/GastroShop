using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFserver
{
    [DataContract]
    public class Category
    {
        
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        public virtual ICollection<Ingredients> Ingredients{ get; set; }
    }
}