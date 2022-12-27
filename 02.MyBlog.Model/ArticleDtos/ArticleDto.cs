using _02.MyBlog.Model.CategoryDtos;
using _02.MyBlog.Model.CommentDtos;
using _02.MyBlog.Model.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MyBlog.Model.ArticleDtos
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public string State { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserDto User { get; set; }
        public CategoryDto Category { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}
