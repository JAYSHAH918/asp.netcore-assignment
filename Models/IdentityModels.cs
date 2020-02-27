using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommentAssignment.Models.BlogPost
{
    public class IdentityModels : ApplicationDbContext

    {
       
    }

    public class ApplicationDbContext
    {
        public DbSet<BlogPosts> BlogPost { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
