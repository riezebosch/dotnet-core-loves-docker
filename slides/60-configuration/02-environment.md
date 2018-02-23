<pre><code class="cs" data-trim data-noescape>
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    <mark>.AddEnvironmentVariables()</mark>
    <mark>.AddEnvironmentVariables("prefix");</mark>

var configuration = builder.Build();
</code></pre>