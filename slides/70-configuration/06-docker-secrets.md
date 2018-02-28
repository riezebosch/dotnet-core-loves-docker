the cool (future) way
<pre><code class="cs" data-trim data-noescape>
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .AddEnvironmentVariables("prefix")
    .AddCommandLine()
    <mark>.AddDockerSecrets();</mark>

var configuration = builder.Build();
</code></pre>

<small style="float: left">
* [source](https://github.com/aspnet/Configuration/tree/dev/src/Config.DockerSecrets)
* [package](https://dotnet.myget.org/feed/dotnet-core/package/nuget/Microsoft.Extensions.Configuration.DockerSecrets)

</small>

note:
```
echo "hello from docker secrets" | docker secret create message -
docker service create --name test --secret message  ${PWD##*/}
```