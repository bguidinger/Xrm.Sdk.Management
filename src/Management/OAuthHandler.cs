namespace BGuidinger.Xrm.Sdk.Management
{
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;

    internal class OAuthHandler : DelegatingHandler
    {
        private readonly string _clientId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
        private readonly Uri _resourceUri;
        private readonly UserCredential _credential;
        private AuthenticationContext _authContext;
        private AuthenticationResult _authResult;

        public OAuthHandler(Uri resourceUri, UserCredential credential) : base(new HttpClientHandler())
        {
            _resourceUri = resourceUri;
            _credential = credential;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (_authResult == null)
            {
                var authParams = await AuthenticationParameters.CreateFromResourceUrlAsync(_resourceUri);
                _authContext = new AuthenticationContext(authParams.Authority);
                _authResult = _authContext.AcquireToken(authParams.Resource, _clientId, _credential);
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