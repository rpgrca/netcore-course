using System;

namespace Mapper.Models.Adapter {
    public class Company
    {
        private Json.Company _Company;

        internal Company(Json.Company company) {
            _Company = company;
        }

        internal void CopyTo(Json.Company company) {
            company.Name = _Company.Name;
            company.CatchPhrase = _Company.CatchPhrase;
            company.Bs = _Company.Bs;
        }

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
    }
}