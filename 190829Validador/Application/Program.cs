using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        private const int TEST_COUNT = 7;

        /// <summary>
        /// Queries for TEST_COUNT lists of users forcing await for each request.
        /// </summary>
        private static async Task AsyncAwait() {
            Mapper.Mapper mapper = new Mapper.Mapper();
            Mapper.Models.Adapter.UsersCollection[] usersCollection = new Mapper.Models.Adapter.UsersCollection[TEST_COUNT];

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int index = 0; index < TEST_COUNT; index++) {
                usersCollection[index] = await mapper.GetUsersAsync();
            }
            stopWatch.Stop();

            Console.WriteLine($"Async/Await: Retrieved {usersCollection.Select(x => x.Count).Sum()} elements in {stopWatch.ElapsedMilliseconds} ms.");
        }

        /// <summary>
        /// Queries for TEST_COUNT lists of users in an asynchronous way.
        /// </summary>
        private static async Task FullAsync() {
            Mapper.Mapper mapper = new Mapper.Mapper();
            Task<Mapper.Models.Adapter.UsersCollection>[] tasks = new Task<Mapper.Models.Adapter.UsersCollection>[TEST_COUNT];
            Mapper.Models.Adapter.UsersCollection[] users = new Mapper.Models.Adapter.UsersCollection[TEST_COUNT];
            int index;

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (index = 0; index < TEST_COUNT; index++) {
                tasks[index] = mapper.GetUsersAsync();
            }

            for (index = 0; index < TEST_COUNT; index++) {
                users[index] = await tasks[index];
            }
            stopWatch.Stop();

            Console.WriteLine($"Fully Async: Retrieved {users.Select(x => x.Count).Sum()} elements in {stopWatch.ElapsedMilliseconds} ms.");
        }

        /// <summary>
        /// Queries for TEST_COUNT lists of users in a synchronous way.
        /// </summary>
        private static void Synchronous() {
            Mapper.Mapper mapper = new Mapper.Mapper();
            Mapper.Models.Adapter.UsersCollection[] users = new Mapper.Models.Adapter.UsersCollection[TEST_COUNT];

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int index = 0; index < TEST_COUNT; index++) {
                users[index] = mapper.GetUsers();
            }
            stopWatch.Stop();

            Console.WriteLine($"Synchronous: Retrieved {users.Select(x => x.Count).Sum()} elements in {stopWatch.ElapsedMilliseconds} ms.");
        }

        static async Task Main(string[] args)
        {
            await AsyncAwait();
            await FullAsync();
            Synchronous();

            Mapper.Mapper mapper = new Mapper.Mapper();
            Mapper.Models.Adapter.Users user = mapper.GetUser(3);
            Console.WriteLine($"User with id {user.Id} is {user.Name}.");

            user = await mapper.GetUserAsync(3);
            Console.WriteLine($"Confirming information, user with id {user.Id} is {user.Name}.");
        }
    }
}
