using _01.MyBlog.Shared;
using _03.MyBlog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MyBlog.Data.Repositories
{
    internal class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
