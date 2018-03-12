namespace WCFserver
{
    using System;

    public class Blogs
    {
        public int ID { get; set; }
        public virtual Account Account { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public DateTime DateTime{ get; set; }
        public virtual BlogsCategory BlogsCategory { get; set; }
        public float Raiting { get; set; }
        public virtual ReadyMeals ReadyMeals { get; set; }

    }
}