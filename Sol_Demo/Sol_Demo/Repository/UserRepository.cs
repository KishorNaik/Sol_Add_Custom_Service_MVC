using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Repository
{
    public interface IUserRepository
    {
        Task<String> GetNames();
    }

    public class UserRepository : IUserRepository
    {
        async Task<string> IUserRepository.GetNames()
        {
            return await Task.Run(() => {

                return "Hello Service";

            });
        }
    }
}
