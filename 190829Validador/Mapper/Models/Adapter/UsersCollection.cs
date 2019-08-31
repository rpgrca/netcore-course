using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper.Models.Json;

namespace Mapper.Models.Adapter
{
    public partial class UsersCollection : IList<Adapter.Users>, IEnumerable<Adapter.Users>
    {
        public class UsersCollectionEnumerator : IEnumerator<Adapter.Users>
        {
            private IEnumerator<Models.Json.Users> InternalEnumerator { get; set; }

            internal UsersCollectionEnumerator(IEnumerator<Models.Json.Users> usersCollection)
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

        #region Constructors
        internal UsersCollection(List<Json.Users> usersCollection) {
            _UsersCollection = usersCollection;
        }

        public UsersCollection() {
            _UsersCollection = new List<Json.Users>();
        }
        #endregion

        #region IEnumerable implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new UsersCollectionEnumerator(_UsersCollection.GetEnumerator());
        }

        public IEnumerator<Users> GetEnumerator()
        {
            return new UsersCollectionEnumerator(_UsersCollection.GetEnumerator());
        }
        #endregion

        #region IList implementation
        public int Count => _UsersCollection.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public Users this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int IndexOf(Users item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Users item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            _UsersCollection.RemoveAt(index);
        }

        public void Add(Users item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _UsersCollection.Clear();
        }

        public bool Contains(Users item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Users[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Users item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}