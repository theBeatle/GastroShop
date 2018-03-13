    using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFserver
{

    public class ProductsType
    {
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        public virtual ICollection<Ingredients> Ingredients{ get; set; }
    }
}