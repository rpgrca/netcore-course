using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper.Models;

namespace Mapper
{
    public class Mapper
    {
        private const string SERVICE_URL = "https://jsonplaceholder.typicode.com/users";
        private readonly System.Uri _ServiceUrl;

        public System.Uri ServiceUrl
        {
            get { return _ServiceUrl; }
        }

        public Mapper()
        {
            this._ServiceUrl = new Uri(SERVICE_URL);
        }

        public async Task<List<Models.Adapter.Users>> GetUsersAsync()
        {
            var request = new Consumer.Request("/", Consumer.Method.Get);
            var consumer = new Consumer.Consumer(this.ServiceUrl);
            List<Models.Json.Users> users = await consumer.ExecuteAsync<List<Models.Json.Users>>(request);

            return new List<Models.Adapter.Users>();
        }
    }
}
