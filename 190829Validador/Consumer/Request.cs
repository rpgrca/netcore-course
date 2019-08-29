using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization;

namespace Consumer
{
    public enum Method
    {
        Get = RestSharp.Method.GET,
        Post = RestSharp.Method.POST
    }

    public class Request
    {
        private readonly RestSharp.RestRequest _RestRequest;
        private readonly Method _Method;

        public Request(string controller, Method method)
        {
            _Method = method;
            _RestRequest = new RestSharp.RestRequest(controller, (RestSharp.Method)method);
        }

        public Request AddParameter(string parameter, string value)
        {
            switch (_Method)
            {
                case Method.Post: _RestRequest.AddParameter(parameter, value, ParameterType.QueryString);
                    break;

                case Method.Get: _RestRequest.AddQueryParameter(parameter, value);
                    break;
            }

            return this;
        }

        public Request AddFile(string parameter, string fileName, byte[] contents)
        {
            _RestRequest.AddFile(parameter, contents, fileName);
            return this;
        }

        internal RestRequest Build()
        {
            return _RestRequest;
        }
    }
}
