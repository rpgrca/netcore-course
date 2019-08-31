using System;

namespace Mapper.Models.Adapter
{
    public class Users
    {
        private readonly Json.Users _Users;
        private readonly Adapter.Address _Address;
        private readonly Adapter.Company _Company;

        #region Constructors
        public Users() {
            _Users = new Json.Users();
            _Address = new Adapter.Address(_Users.Address);
            _Company = new Adapter.Company(_Users.Company);
        }

        internal Users(Json.Users users) {
            _Users = users;
            _Address = new Adapter.Address(_Users.Address);
            _Company = new Adapter.Company(_Users.Company);
        }
        #endregion

        #region Accessors
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
                return _Address;
            }
            set {
                Models.Adapter.Address.Copy(value, _Address);
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
                return _Company;
            }
            set {
                Models.Adapter.Company.Copy(value, _Company);
            }
        }
        #endregion

        public override string ToString() {
            return $"Id: {Id}, Name: {Name}, Username: {Username}, Email: {Email}, Address: {Address.ToString()}, Phone: {Phone}, Website: {Website}, Company: {Company.ToString()}";
        }
    }
}
