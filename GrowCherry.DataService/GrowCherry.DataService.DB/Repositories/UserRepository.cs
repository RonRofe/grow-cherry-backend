using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrowCherry.DataService.DB.EntityFramework;
using GrowCherry.DataService.Data.Models;

namespace GrowCherry.DataService.DB.Repositories
{
    public class UserRepository : RepositoryBase
    {
        public UserRepository(GrowCherryEntities context) : base(context)
        {

        }

        public User GetUser(int id)
        {
            var response = Context.user_Users.FirstOrDefault(u => u.Id == id);
            return DbToObject(response);
        }

        public User UpdateUser(User user)
        {
            user_Users entity = Context.user_Users.FirstOrDefault(u => u.Id == user.Id);
            entity = ObjectToDb(user, entity);
            Context.SaveChanges();

            return GetUser(entity.Id);
        }

        private User DbToObject(user_Users entity)
        {
            if (entity == null)
            {
                return new User();
            }
                

            return new User
            {
                Id = entity.Id,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber
            };
        }

        private user_Users ObjectToDb(User user, user_Users entity=null)
        {
            if(entity==null)
            {
                entity = new user_Users();
            }

            entity.Id = user.Id;
            entity.Email = user.Email;
            entity.PhoneNumber = user.PhoneNumber;

            return entity;
           
        }
    }
}
