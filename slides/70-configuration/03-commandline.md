maybe useful?
<pre><code class="cs" data-trim data-noescape>
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .AddEnvironmentVariables("prefix")
    <mark>.AddCommandLine();</mark>

var configuration = builder.Build();
</code></pre>