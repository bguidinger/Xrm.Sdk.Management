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
        Task<TResponse> Execute<TResponse>(Message request) where TResponse : class;
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

        public async Task<TResponse> Execute<TResponse>(Message message) where TResponse : class
        {
            using (var request = GetRequest(message))
            {
                return await GetResponse<TResponse>(request);
            }
        }

        private HttpRequestMessage GetRequest(Message message)
        {
            if (message.Validation.IsValid == false)
            {
                throw new ValidationException(message.Validation);
            }

            var request = new HttpRequestMessage(message.Method, $"/api/v{Version}{message.RequestUri}");
            request.Headers.AcceptLanguage.Add(new StringWithQualityHeaderValue(Language));
            if (message.Method != HttpMethod.Get)
            {
                using (var stream = new MemoryStream())
                using (var writer = new StreamWriter(stream))
                using (var json = new JsonTextWriter(writer))
                {
                    var serializer = new JsonSerializer
                    {
                        Formatting = Formatting.None,
                        NullValueHandling = NullValueHandling.Ignore
                    };
                    serializer.Serialize(json, message);

                    var content = new StreamContent(stream);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    request.Content = content;
                }
            }
            return request;
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