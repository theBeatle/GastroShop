namespace WCFserver
{
    using System.Collections.Generic;

    public class BlogsCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Blogs> Blog { get; set; }
    }
}