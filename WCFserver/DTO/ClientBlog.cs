using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFserver
{
    public class ClientBlog
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string NameCategory { get; set; }
        public double Raiting { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime TimeCreate { get; set; }
        public string NamedDishes { get; set; }
    }
}