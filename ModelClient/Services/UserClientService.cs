using ModelClient.Data;
using ModelClient.Mapper;
using ModelGlobal.Data;
using ModelGlobal.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.SecurityTools;

namespace ModelClient.Services
{
    public class UserClientService : IRepoUser<UserClient>
    {
        private IRepoUser<UserGlobal> _userService;
        public UserClientService()
        {
            _userService = new UserGlobalService();
        }

        public bool Delete(int id)
        {
            return _userService.Delete(id);
        }

        public IEnumerable<UserClient> Get()
        {
            return _userService.Get().Select(u => u.ToUserClient());
        }

        public UserClient Get(int id)
        {
            return _userService.Get(id)?.ToUserClient();
        }

        public int Post(UserClient user)
        {
            return _userService.Post(user.ToUserGlobal());
        }

        public bool Put(int id, UserClient user)
        {
            return _userService.Put(id, user.ToUserGlobal());
        }
    }
}
