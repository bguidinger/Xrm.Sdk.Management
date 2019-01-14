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

    public class ManagementClient
    {
        private string _clientId;
        private readonly HttpClient _client = new HttpClient();
        private AuthenticationContext _authContext;
        private AuthenticationResult _authResult;

        public ManagementClient(string serviceUrl)
        {
            _client.BaseAddress = new Uri(serviceUrl);
        }

        public void Authenticate(NetworkCredential credential)
        {
            var resourceUri = new Uri(_client.BaseAddress + "/api/aad/challenge");
            var authParams = AuthenticationParameters.CreateFromResourceUrlAsync(resourceUri).Result;

            _authContext = new AuthenticationContext(authParams.Authority);
            _clientId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
            _authResult = _authContext.AcquireTokenAsync(authParams.Resource, _clientId, new UserCredential(credential.UserName, credential.SecurePassword)).Result;
        }

        public void Authenticate(ClientCredential credential)
        {
            var resourceUri = new Uri(_client.BaseAddress + "/api/aad/challenge");
            var authParams = AuthenticationParameters.CreateFromResourceUrlAsync(resourceUri).Result;

            _authContext = new AuthenticationContext(authParams.Authority);
            _clientId = credential.ClientId;
            _authResult = _authContext.AcquireTokenAsync(authParams.Resource, credential).Result;
        }

        public async Task<TResponse> Execute<TResponse>(Request request) where TResponse : class
        {
            if (_authResult == null || _authResult.ExpiresOn < DateTimeOffset.UtcNow)
            {
                _authResult = await _authContext.AcquireTokenByRefreshTokenAsync(_authResult.RefreshToken, _clientId);
            }
            return await GetResponse<TResponse>(GetMessage(request));
        }

        private HttpRequestMessage GetMessage(Request request)
        {
            var message = new HttpRequestMessage(request.Method, "/api/v1.1" + request.RequestUri);
            message.Headers.Authorization = new AuthenticationHeaderValue(_authResult.AccessTokenType, _authResult.AccessToken);
            message.Headers.AcceptLanguage.Add(new StringWithQualityHeaderValue("en-US"));
            if (request.Method != HttpMethod.Get)
            {
                var json = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
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
    }
}