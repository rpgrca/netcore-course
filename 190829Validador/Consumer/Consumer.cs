using System;
using System.Threading.Tasks;
using RestSharp;

namespace Consumer
{
    public class Consumer
    {
        private readonly System.Uri _BaseUrl;
        private readonly IRestClient _RestClient;

        public Consumer(Uri baseUrl)
        {
            _BaseUrl = baseUrl;
            _RestClient = new RestClient(_BaseUrl)
                .UseSerializer(() => new JsonNetSerializer());
        }

        public T Execute<T>(Request request) where T : new() {
            var response = _RestClient.Execute<T>(request.Build());

            if (! response.IsSuccessful) {
                throw new InvalidOperationException($"Bad response! {response.StatusDescription} (code: {response.StatusCode}).", response.ErrorException);
            }

            return response.Data;
        }

        public async Task<T> ExecuteAsync<T>(Request request) where T : new()
        {
            var taskCompletionSource = new TaskCompletionSource<T>();
            _RestClient.ExecuteAsync<T>(request.Build(), (response, handle) =>
            {
                try
                {
                    if (!response.IsSuccessful)
                    {
                        taskCompletionSource.SetException(new InvalidOperationException($"Exception caught! {response.StatusDescription} (status code {response.StatusCode})", response.ErrorException));
                    }
                    else
                    {
                        taskCompletionSource.SetResult(response.Data);
                    }
                }
                catch (Exception ex)
                {
                    taskCompletionSource.SetException(ex);
                }
            });

            return await taskCompletionSource.Task.ConfigureAwait(false);
        }
    }
}
