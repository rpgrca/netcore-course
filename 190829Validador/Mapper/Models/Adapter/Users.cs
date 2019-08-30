using System;

namespace Mapper.Models.Adapter
{
    public class Users
    {
        private Json.Users _Users;

        public Users() {
            _Users = new Json.Users();
        }

        internal Users(Json.Users users) {
            _Users = users;
        }

        public long Id {
            get {
                return _Users.Id;
            }
            set {
                _Users.Id = value;
            }
        }

        public string Name {
            get {
                return _Users.Name;
            }
            set {
                _Users.Name = value;
            }
        }

        public string Username {
            get {
                return _Users.Username;
            }
            set {
                _Users.Username = value;
            }
        }

        public string Email {
            get {
                return _Users.Email;
            }
            set {
                _Users.Email = value;
            }
        }

        public Address Address {
            get {
                return new Adapter.Address(_Users.Address);
            }
            set {
                value.CopyTo(_Users.Address);
            }
        }

        public string Phone {
            get {
                return _Users.Phone;
            }
            set {
                _Users.Phone = value;
            }
        }

        public string Website {
            get {
                return _Users.Website;
            }
            set {
                _Users.Website = value;
            }
        }

        public Company Company {
            get {
                return new Adapter.Company(_Users.Company);
            }
            set {
                value.CopyTo(_Users.Company);
            }
        }
    }
}
