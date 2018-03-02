### ASP.NET Core MVC
<pre><code class="cs" data-trim data-noescape>
public class Program
{
    <mark>public static void Main(string[] args)</mark>
    {
        BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
}
</code></pre>

note:
https://github.com/dotnet/docs/blob/master/docs/core/deploying/runtime-store.md#aspnet-core-implicit-store
Runtime Package Store or SDK required (by default)