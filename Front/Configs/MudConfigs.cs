using MudBlazor.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Front.Configs;

public static class MudConfigs
{
    public static void AddMudConfigs(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddMudServices();
    }
}
