using System;
using Newtonsoft.Json;

namespace Mapper.Models.Json {
public partial class Geo
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}