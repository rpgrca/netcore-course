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

        public T Execute<T, U>(Request request, Interfaces.IAdapterFactory<T, U> factory)
            where U : new()
        {
            var response = _RestClient.Execute<U>(request.Build());

            if (! response.IsSuccessful) {
                throw new InvalidOperationException($"Bad response! {response.StatusDescription} (code: {response.StatusCode}).", response.ErrorException);
            }

            return factory.Build(response.Data);
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

        public async Task<T> ExecuteAsync<T, U>(Request request, Interfaces.IAdapterFactory<T, U> factory)
            where U : new()
        {
            var taskCompletionSource = new TaskCompletionSource<T>();
            _RestClient.ExecuteAsync<U>(request.Build(), (response, handle) =>
            {
                try
                {
                    if (!response.IsSuccessful)
                    {
                        taskCompletionSource.SetException(new InvalidOperationException($"Exception caught! {response.StatusDescription} (status code {response.StatusCode})", response.ErrorException));
                    }
                    else
                    {
                        // If callback is successful, build the adapter from the Json source
                        taskCompletionSource.SetResult(factory.Build(response.Data));
                    }
                }
                catch (Exception ex)
                {
                    taskCompletionSource.SetException(ex);
                }
            });

            return await taskCompletionSource.Task.ConfigureAwait(false);
        }

#if false
        public async Task<T> ExecuteAsync<T, U>(Request request)
            where T : Interfaces.IAdaptFrom<U>, new()
            where U : new()
        {
            var taskCompletionSource = new TaskCompletionSource<T>();
            _RestClient.ExecuteAsync<U>(request.Build(), (response, handle) =>
            {
                try
                {
                    if (!response.IsSuccessful)
                    {
                        taskCompletionSource.SetException(new InvalidOperationException($"Exception caught! {response.StatusDescription} (status code {response.StatusCode})", response.ErrorException));
                    }
                    else
                    {
                        // If callback is successful, build the adapter from the Json source
                        T wrapper = new T();
                        wrapper.AdaptFrom(response.Data);
                        taskCompletionSource.SetResult(wrapper);
                    }
                }
                catch (Exception ex)
                {
                    taskCompletionSource.SetException(ex);
                }
            });

            return await taskCompletionSource.Task.ConfigureAwait(false);
        }
#endif
    }
}
