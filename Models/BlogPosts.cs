using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommentAssignment.Models
{
    public class BlogPosts
    {
        public int BlogPostID { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        internal class ApplicationDbContext
        {
            public object BlogPosts { get; internal set; }
            public IEnumerable<object> Comment { get; internal set; }

            internal object BlogPost()
            {
               
                throw new NotImplementedException();
            }

            internal void SaveChanges()
            {
                throw new NotImplementedException();
            }
        }
    }
}
