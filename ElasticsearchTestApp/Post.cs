using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchTestApp
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime PostDate { get; set; }
        public string PostText { get; set; }
    }
}
