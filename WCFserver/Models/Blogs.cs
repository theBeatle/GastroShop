using System;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace WCFserver
{

    public class Blogs
    {
        public int ID { get; set; }
        [DataMember]
        public virtual Account Account { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public DateTime DateTime{ get; set; }
        public virtual BlogsCategory BlogsCategory { get; set; }
        [DataMember]
        public double Raiting { get; set; }
        public virtual ReadyMeals ReadyMeals { get; set; }

    }
}