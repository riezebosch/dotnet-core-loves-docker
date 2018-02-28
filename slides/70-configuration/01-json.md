the 'old' way
<pre><code class="cs" data-trim data-noescape>
var builder = new ConfigurationBuilder()
    <mark>.AddJsonFile("appsettings.json");</mark>

var configuration = builder.Build();
</code></pre>

note: 
```
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Json
```