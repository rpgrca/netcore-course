using System;

namespace Mapper.Models.Adapter {
    public class Address
    {
        private Json.Address _Address;

        internal Address(Json.Address address) {
            _Address = address;
        }

        internal Address() {
            _Address = new Json.Address();
        }

        internal void CopyTo(Json.Address address) {
            address.City = _Address.City;
            address.Street = _Address.Street;
            address.Suite = _Address.Suite;
            address.Zipcode = _Address.Zipcode;

            new Adapter.Geo(address.Geo).CopyTo(address.Geo);
        }

        public string Street {
            get {
                return _Address.Street;
            }
            set {
                _Address.Street = value;
            }
        }

        public string Suite {
            get {
                return _Address.Street;
            }
            set {
                _Address.Street = value;
            }
        }

        public string City {
            get {
                return _Address.City;
            }
            set {
                _Address.City = value;
            }
        }
        public string Zipcode {
            get {
                return _Address.Zipcode;
            }
            set {
                _Address.Zipcode = value;
            }
        }

        public Adapter.Geo Geo {
            get {
                return new Adapter.Geo(_Address.Geo);
            }
            set {
                value.CopyTo(_Address.Geo);
            }
        }
    }
}