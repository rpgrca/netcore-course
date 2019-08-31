using System.Collections.Generic;

namespace Mapper.Models
{
    public class UsersAdapterFactory : Consumer.Interfaces.IAdapterFactory<Models.Adapter.Users, Models.Json.Users>
    {
        public Models.Adapter.Users Build(Models.Json.Users source)
        {
            return new Models.Adapter.Users(source);
        }
    }
}