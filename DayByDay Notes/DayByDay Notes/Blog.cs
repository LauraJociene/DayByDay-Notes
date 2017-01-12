using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayByDay_Notes
{
    
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public DateTime Date { get
            {
                return DateTime.Now;
            } set { } }

        public List<Post> Posts { get; set; }
    }
    
}
