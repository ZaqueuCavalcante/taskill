using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace Front.Auth;

public class TaskillDelegatingHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);

        // var token = await _localStorage.GetItemAsync("AccessToken");
        // request.Headers.Add("Authorization", $"Bearer {token}");

        return await base.SendAsync(request, cancellationToken);
    }
}
