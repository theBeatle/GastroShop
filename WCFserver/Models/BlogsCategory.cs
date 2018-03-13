    using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFserver
{

    public class BlogsCategory
    {
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        public virtual ICollection<Blogs> Blog { get; set; }
    }
}