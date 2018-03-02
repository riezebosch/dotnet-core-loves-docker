<pre><code class="cs" data-trim data-noescape>
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    <mark>.AddJsonFile($"appsettings.{env.Environment}.json", true, false);</mark>

var configuration = builder.Build();
</code></pre>

`ASPNETCORE_ENVIRONMENT`