#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommentsService.Models;

namespace CommentsService.Data
{
    public class CommentsServiceContext : DbContext
    {
        public CommentsServiceContext (DbContextOptions<CommentsServiceContext> options)
            : base(options)
        {
        }

        public DbSet<CommentsService.Models.Comment> Comment { get; set; }
    }
}
