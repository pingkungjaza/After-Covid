using newbackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newbackend.Services
{
    public interface IAuthRepository
    {
        void Register(Users user);
        (Users, string) Login(Users user);

    }
}
