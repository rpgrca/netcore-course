using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper.Models;
using Mapper.Models.Adapter;
using Mapper.Models.Json;

namespace Mapper
{
    public class AdapterMapper
    {
        private const string SERVICE_URL = "https://jsonplaceholder.typicode.com";
        private readonly System.Uri _ServiceUrl;

        #region Constructors
        public AdapterMapper()
        {
            this._ServiceUrl = new Uri(SERVICE_URL);
        }
        #endregion

        #region Accessors
        public System.Uri ServiceUrl
        {
            get { return _ServiceUrl; }
        }
        #endregion

        #region API calls
        public Models.Adapter.UsersCollection GetUsers() {
            var request = new Consumer.Request("/users", Consumer.Method.Get);
            var consumer = new Consumer.Consumer(this.ServiceUrl);

            return consumer.Execute<Models.Adapter.UsersCollection, List<Models.Json.Users>>(request, new UsersCollectionAdapterFactory());
        }

        public async Task<Models.Adapter.UsersCollection> GetUsersAsync() {
            var request = new Consumer.Request("/users", Consumer.Method.Get);
            var consumer = new Consumer.Consumer(this.ServiceUrl);

            return await consumer.ExecuteAsync<Models.Adapter.UsersCollection, List<Models.Json.Users>>(request, new UsersCollectionAdapterFactory());
        }

#if false
        public async Task<Models.Adapter.UsersCollection> GetUsersAsync() {
            var taskCompletionSource = new TaskCompletionSource<Models.Adapter.UsersCollection>();
            var request = new Consumer.Request("/users", Consumer.Method.Get);
            var consumer = new Consumer.Consumer(this.ServiceUrl);

            return await consumer.ExecuteAsync<Models.Adapter.UsersCollection, List<Models.Json.Users>>(request);
        }
#endif

        public Models.Adapter.Users GetUser(int id) {
            var request = new Consumer.Request("/users/{id}", Consumer.Method.Get);
            request.AddParameter("id", id.ToString(), true);

            var consumer = new Consumer.Consumer(this.ServiceUrl);
            return consumer.Execute<Models.Adapter.Users, Models.Json.Users>(request, new UsersAdapterFactory());
        }

        public async Task<Models.Adapter.Users> GetUserAsync(int id) {
            var request = new Consumer.Request("/users/{id}", Consumer.Method.Get);
            request.AddParameter("id", id.ToString(), true);

            var consumer = new Consumer.Consumer(this.ServiceUrl);
            return await consumer.ExecuteAsync<Models.Adapter.Users, Models.Json.Users>(request, new UsersAdapterFactory());
        }
        #endregion
    }
}
