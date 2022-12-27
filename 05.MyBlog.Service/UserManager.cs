using _02.MyBlog.Model.UserDtos;
using _04.MyBlog.Data.Repositories;
using _05.MyBlog.Service.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MyBlog.Service
{
    public class UserManager
    {
        private readonly IUnitOfWork unitOfWork;
        public UserManager()
        {
            unitOfWork = new UnitOfWork();
        }

        public UserDto LoginCheck(string username, string password)
        {
            return unitOfWork.UserRepository.Get(u => u.Username == username && u.Password == password && !u.IsDeleted).ToDto();
        }
    }
}
