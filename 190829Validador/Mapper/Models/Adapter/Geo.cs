using System;

namespace Mapper.Models.Adapter {
    public class Geo
    {
        private Json.Geo _Geo;

        internal Geo(Json.Geo geo) {
            _Geo = geo;
        }

        internal Geo() {
            _Geo = new Json.Geo();
        }

        internal void CopyTo(Json.Geo geo) {
            geo.Lat = _Geo.Lat;
            geo.Lng = _Geo.Lng;
        }

        public string Lat
        {
            get { return _Geo.Lat; }
            set { _Geo.Lat = value; }
        }
        
        public string Lng
        {
            get { return _Geo.Lng; }
            set { _Geo.Lng = value; }
        }
    }
}
