using _02.MyBlog.Model.CommentDtos;
using _05.MyBlog.Service;
using _06.MyBlog.API.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _06.MyBlog.API.Controllers
{
    
    public class CommentController : BaseController
    {
        [HttpGet]
        [Route("GetListNonDeletedByArticleId")]
        public List<CommentDto> GetListNonDeletedByArticleId(int articleId)
        {
            CommentManager commentManager = new();
            return commentManager.GetListNonDeletedByArticleId(articleId);
        }

        [HttpGet]
        [Route("GetListByArticleId")]
        public List<CommentDto> GetListByArticleId(int articleId)
        {
            CommentManager commentManager = new();
            return commentManager.GetListByArticleId(articleId);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Add")]
        public void Add([FromBody] AddCommentDto addCommentDto)
        {
            CommentManager commentManager = new();
            commentManager.Add(addCommentDto);
        }

        [HttpGet]
        [Route("Delete")]
        public void Delete(int commentId)
        {
            CommentManager commentManager = new();
            commentManager.Delete(commentId);
        }
    }
}
