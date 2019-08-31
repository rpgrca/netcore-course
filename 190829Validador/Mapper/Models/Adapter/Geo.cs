using System;

namespace Mapper.Models.Adapter {
    public class Geo
    {
        private readonly Json.Geo _Geo;

        #region Constructors
        internal Geo(Json.Geo geo) {
            _Geo = geo;
        }

        internal Geo() {
            _Geo = new Json.Geo();
        }
        #endregion

        #region Accessors
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
        #endregion

        internal static void Copy(Adapter.Geo from, Adapter.Geo to) {
            to.Lat = from.Lat;
            to.Lng = from.Lng;
        }

        public override string ToString() {
            return $"Lat: {Lat}, Lng: {Lng}";
        }
    }
}
