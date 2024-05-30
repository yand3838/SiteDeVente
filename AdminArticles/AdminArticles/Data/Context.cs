using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminArticles.Models;

namespace Articles
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<AdminArticles.Models.ArticleModel> ArticleModel { get; set; } = default!;
    }
}
