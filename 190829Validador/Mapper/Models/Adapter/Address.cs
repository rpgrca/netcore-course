using System;

namespace Mapper.Models.Adapter {
    public class Address
    {
        private readonly Json.Address _Address;
        private readonly Adapter.Geo _Geo;

        #region Constructors
        internal Address(Json.Address address) {
            _Address = address;
            _Geo = new Adapter.Geo(_Address.Geo);
        }

        internal Address() {
            _Address = new Json.Address();
            _Geo = new Adapter.Geo(_Address.Geo);
        }
        #endregion

        #region Accessors
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
                return _Geo;
            }
             set {
                 Adapter.Geo.Copy(value, _Geo);
            }
        }
        #endregion

        internal static void Copy(Models.Adapter.Address from, Models.Adapter.Address to) {
            to.City = from.City;
            to.Street = from.Street;
            to.Suite = from.Suite;
            to.Zipcode = from.Zipcode;

            Models.Adapter.Geo.Copy(from.Geo, to.Geo);
        }

        public override string ToString() {
            return $"Street: {Street}, Suite: {Suite}, City: {City}, Zipcode: {Zipcode}, Geo: {Geo.ToString()}";
        }
    }
}