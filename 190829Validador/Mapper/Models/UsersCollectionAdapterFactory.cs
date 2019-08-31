using System.Collections.Generic;

namespace Mapper.Models
{
    public class UsersCollectionAdapterFactory : Consumer.Interfaces.IAdapterFactory<Models.Adapter.UsersCollection, List<Models.Json.Users>>
    {
        public Models.Adapter.UsersCollection Build(List<Models.Json.Users> source)
        {
            return new Models.Adapter.UsersCollection(source);
        }
    }
}