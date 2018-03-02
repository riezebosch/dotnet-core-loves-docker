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