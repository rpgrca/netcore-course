using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Mapper.Mapper mapper = new Mapper.Mapper();
            List<Mapper.Models.Adapter.Users> users = await mapper.GetUsersAsync();

            Console.WriteLine(users.Count);
        }
    }
}
