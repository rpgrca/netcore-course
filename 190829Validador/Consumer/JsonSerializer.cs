using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp.Serialization;
using RestSharp;

namespace Consumer
{
    internal class JsonNetSerializer : IRestSerializer
    {
        private JsonSerializerSettings GetSettings() => (
            new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy
                    {
                        ProcessDictionaryKeys = false
                    }
                },
                Formatting = Formatting.Indented
            }
        );

        public string Serialize(object obj) => (JsonConvert.SerializeObject(obj, GetSettings()));

        public string Serialize(Parameter parameter) => (JsonConvert.SerializeObject(parameter.Value, GetSettings()));

        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content, GetSettings());
        }

        public string[] SupportedContentTypes { get; } =
        {
            "application/json", "text/json", "text/x-json", "text/javascript", "*+json"
        };

        public string ContentType { get; set; } = "application/json";

        public DataFormat DataFormat { get; } = DataFormat.Json;
    }
}
