using Front.Auth;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Front.Configs;

public static class HttpConfigs
{
    public static void AddHttpConfigs(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddScoped<TaskillDelegatingHandler>();

        builder.Services
            .AddHttpClient("HttpClient", x => x.BaseAddress = new Uri(builder.GetUrl()))
            .AddHttpMessageHandler<TaskillDelegatingHandler>();

        builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
            .CreateClient("HttpClient"));
    }
}
