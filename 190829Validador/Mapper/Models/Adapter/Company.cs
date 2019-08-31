using System;

namespace Mapper.Models.Adapter {
    public class Company
    {
        private readonly Json.Company _Company;

        #region Constructors
        internal Company(Json.Company company) {
            _Company = company;
        }
        #endregion

        #region Accessors
        public string Name {
            get {
                return _Company.Name;
            }
            set {
                _Company.Name = value;
            }
        }

        public string CatchPhrase {
            get {
                return _Company.CatchPhrase;
            }
            set {
                _Company.CatchPhrase = value;
            }
        }

        public string Bs {
            get {
                return _Company.Bs;
            }
            set {
                _Company.Bs = value;
            }
        }
        #endregion

        internal static void Copy(Adapter.Company from, Adapter.Company to) {
            to.Name = from.Name;
            to.CatchPhrase = from.CatchPhrase;
            to.Bs = from.Bs;
        }

        public override string ToString() {
            return $"Company Name: {Name}, Company CatchPhrase: {CatchPhrase}, Company Bs: {Bs}";
        }
    }
}