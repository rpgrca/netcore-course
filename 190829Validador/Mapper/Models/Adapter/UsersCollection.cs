using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Models.Adapter
{
    public partial class UsersCollection : IEnumerable<Adapter.Users>
    {
        public class UsersCollectionEnumerator : IEnumerator<Adapter.Users>
        {
            private IEnumerator<List<Models.Json.Users>> InternalEnumerator { get; set; }

            internal UsersCollectionEnumerator(IEnumerator<List<Models.Json.Users>> usersCollection)
            {
                this.InternalEnumerator = usersCollection;
            }

            public Adapter.Users Current
            {
                get
                {
                    return new Adapter.Users(this.InternalEnumerator.Current);
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            // CA1063
            protected virtual void Dispose(bool nativeOnly)
            {
                this.InternalEnumerator.Dispose();
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return new Users(this.InternalEnumerator.Current);
                }
            }

            public bool MoveNext()
            {
                return this.InternalEnumerator.MoveNext();
            }

            public void Reset()
            {
                this.InternalEnumerator.Reset();
            }
        }

        private readonly List<Json.Users> _UsersCollection;

        internal UsersCollection(List<Json.Users> usersCollection) {
            _UsersCollection = usersCollection;
        }

    }
}