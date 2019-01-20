namespace BGuidinger.Xrm.Sdk.Management
{
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;

    internal class OAuthHandler : DelegatingHandler
    {
        private string _clientId;
        private AuthenticationContext _authContext;
        private AuthenticationParameters _authParams;
        private AuthenticationResult _authResult;

        public OAuthHandler(string serviceUrl, HttpMessageHandler innerHandler) : base(innerHandler)
        {
            var resourceUri = new Uri(serviceUrl + "/api/aad/challenge");
            _authParams = AuthenticationParameters.CreateFromResourceUrlAsync(resourceUri).Result;
            _authContext = new AuthenticationContext(_authParams.Authority);
        }

        public void Authenticate(NetworkCredential credential)
        {
            _clientId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
            var userCredential = new UserCredential(credential.UserName, credential.SecurePassword);
            _authResult = _authContext.AcquireTokenAsync(_authParams.Resource, _clientId, userCredential).Result;
        }

        public void Authenticate(ClientCredential credential)
        {
            _clientId = credential.ClientId;
            _authResult = _authContext.AcquireTokenAsync(_authParams.Resource, credential).Result;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (_authResult == null)
            {
                throw new Exception("Not authenticated.");
            }

            if (_authResult.ExpiresOn < DateTimeOffset.UtcNow)
            {
                _authResult = await _authContext.AcquireTokenByRefreshTokenAsync(_authResult.RefreshToken, _clientId);
            }

            request.Headers.Authorization = new AuthenticationHeaderValue(_authResult.AccessTokenType, _authResult.AccessToken);

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
