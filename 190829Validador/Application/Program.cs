using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        private const int TEST_COUNT = 5;

        private static void DumpUsers(Mapper.Models.Adapter.UsersCollection[] usersCollection) {
            for (int index = 0; index < TEST_COUNT; index++) {
                foreach (Mapper.Models.Adapter.Users user in usersCollection[index]) {
                    System.Diagnostics.Debug.Print(user.ToString());
                }
            }
        }

        /// <summary>
        /// Queries for TEST_COUNT lists of users forcing await for each request.
        /// </summary>
        private static async Task AsyncAwait() {
            Mapper.AdapterMapper mapper = new Mapper.AdapterMapper();
            Mapper.Models.Adapter.UsersCollection[] usersCollection = new Mapper.Models.Adapter.UsersCollection[TEST_COUNT];

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int index = 0; index < TEST_COUNT; index++) {
                usersCollection[index] = await mapper.GetUsersAsync();
            }
            stopWatch.Stop();

            Console.WriteLine($"Async/Await: Retrieved {usersCollection.Select(x => x.Count).Sum()} elements in {stopWatch.ElapsedMilliseconds} ms.");
            DumpUsers(usersCollection);
        }

        /// <summary>
        /// Queries for TEST_COUNT lists of users in an asynchronous way.
        /// </summary>
        private static async Task FullAsync() {
            Mapper.AdapterMapper mapper = new Mapper.AdapterMapper();
            Task<Mapper.Models.Adapter.UsersCollection>[] tasks = new Task<Mapper.Models.Adapter.UsersCollection>[TEST_COUNT];
            Mapper.Models.Adapter.UsersCollection[] usersCollection = new Mapper.Models.Adapter.UsersCollection[TEST_COUNT];
            int index;

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (index = 0; index < TEST_COUNT; index++) {
                tasks[index] = mapper.GetUsersAsync();
            }

            for (index = 0; index < TEST_COUNT; index++) {
                usersCollection[index] = await tasks[index];
            }
            stopWatch.Stop();

            Console.WriteLine($"Fully Async: Retrieved {usersCollection.Select(x => x.Count).Sum()} elements in {stopWatch.ElapsedMilliseconds} ms.");
            DumpUsers(usersCollection);
        }

        /// <summary>
        /// Queries for TEST_COUNT lists of users in a synchronous way.
        /// </summary>
        private static void Synchronous() {
            Mapper.AdapterMapper mapper = new Mapper.AdapterMapper();
            Mapper.Models.Adapter.UsersCollection[] usersCollection = new Mapper.Models.Adapter.UsersCollection[TEST_COUNT];
            int index;

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (index = 0; index < TEST_COUNT; index++) {
                usersCollection[index] = mapper.GetUsers();
            }
            stopWatch.Stop();

            Console.WriteLine($"Synchronous: Retrieved {usersCollection.Select(x => x.Count).Sum()} elements in {stopWatch.ElapsedMilliseconds} ms.");
            DumpUsers(usersCollection);
        }

        static async Task Main(string[] args)
        {
            await AsyncAwait();
            await FullAsync();
            Synchronous();

            Mapper.AdapterMapper mapper = new Mapper.AdapterMapper();
            Mapper.Models.Adapter.Users user = mapper.GetUser(3);
            Console.WriteLine($"User with id {user.Id} is {user.Name}.");

            user = await mapper.GetUserAsync(3);
            Console.WriteLine($"Confirming information, user with id {user.Id} is {user.Name}.");
        }
    }
}
