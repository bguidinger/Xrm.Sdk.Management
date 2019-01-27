namespace BGuidinger.Xrm.Sdk.Management
{
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    public interface IManagementClient
    {
        Task<TResponse> Execute<TResponse>(Request request) where TResponse : class;
    }

    public class ManagementClient : IManagementClient, IDisposable
    {
        private readonly HttpClient _client = new HttpClient();

        public ManagementClient(Location location, UserCredential credential)
        {
            var serviceUrl = GetServiceUrl(location);
            var resourceUri = new Uri(serviceUrl + "/api/aad/challenge");
            var handler = new OAuthHandler(resourceUri, credential);
            _client = new HttpClient(handler, true)
            {
                BaseAddress = new Uri(serviceUrl)
            };
        }

        private string GetServiceUrl(Location location)
        {
            var number = location == 0 ? string.Empty : location.ToString();
            return $"https://admin.services.crm{number}.dynamics.com";
        }

        public string Version { get; set; } = "1.1";
        public string Language { get; set; } = "en-US";

        public async Task<TResponse> Execute<TResponse>(Request request) where TResponse : class
        {
            using (var message = GetMessage(request))
            {
                return await GetResponse<TResponse>(GetMessage(request));
            }
        }

        private HttpRequestMessage GetMessage(Request request)
        {
            var message = new HttpRequestMessage(request.Method, $"/api/v{Version}{request.RequestUri}");
            message.Headers.AcceptLanguage.Add(new StringWithQualityHeaderValue(Language));
            if (request.Method != HttpMethod.Get)
            {
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.None,
                    NullValueHandling = NullValueHandling.Ignore
                };
                var json = JsonConvert.SerializeObject(request, settings);
                message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }
            return message;
        }

        private async Task<TResponse> GetResponse<TResponse>(HttpRequestMessage message) where TResponse : class
        {
            using (var response = await _client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead))
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(stream))
                using (var json = new JsonTextReader(reader))
                {
                    var serializer = new JsonSerializer();

                    if (response.IsSuccessStatusCode)
                    {
                        return serializer.Deserialize<TResponse>(json);
                    }
                    else
                    {
                        var status = serializer.Deserialize<OperationStatus>(json);
                        throw new OperationException(status);
                    }
                }
            }
        }

        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                _client.Dispose();
            }
            disposed = true;
        }
    }
}