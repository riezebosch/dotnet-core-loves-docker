```cs
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .AddEnvironmentVariables("prefix")
    .AddCommandLine()
    .AddDockerSecrets();

var configuration = builder.Build();
```

<small>
* source: https://github.com/aspnet/Configuration/tree/dev/src/Config.DockerSecrets
* package: https://dotnet.myget.org/feed/dotnet-core/package/nuget/Microsoft.Extensions.Configuration.DockerSecrets

</small>