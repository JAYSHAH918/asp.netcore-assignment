using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommentAssignment.Models
{
    public class Comment
    {
        public int CommentID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        public int BlogPostID { get; set; }
    }
}
