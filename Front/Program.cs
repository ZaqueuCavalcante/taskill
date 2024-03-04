var builder = WasmConfigs.CreateHostBuilder(args);

builder.AddMudConfigs();
builder.AddHttpConfigs();
builder.AddClientsConfigs();

await builder.Build().RunAsync();

public partial class Program { }
