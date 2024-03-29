﻿using _02.MyBlog.Model.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MyBlog.Model.CommentDtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserDto User { get; set; }
    }
}
