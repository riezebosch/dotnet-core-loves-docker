```cs
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .AddEnvironmentVariables("prefix")
    .AddCommandLine();

var configuration = builder.Build();
```