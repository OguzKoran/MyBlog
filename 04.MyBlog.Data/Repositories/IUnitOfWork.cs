﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MyBlog.Data.Repositories
{
    public interface IUnitOfWork
    {
        IArticleRepository ArticleRepository { get; }
        IUserRepository UserRepository { get; }
        ICommentRepository CommentRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        void SaveChanges();
    }
}
