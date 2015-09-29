using Gallery.DAL.Abstract;
using Gallery.DAL.Abstract.Repositories;
using Gallery.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
    }
}
