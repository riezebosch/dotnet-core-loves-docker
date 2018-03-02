<pre><code class="cs" data-trim data-noescape>
public class Program
{
  public static void Main(string[] args)
  {
    BuildWebHost(args).Run();
  }

  public static IWebHost BuildWebHost(string[] args) =>
      WebHost.<mark>CreateDefaultBuilder(args)</mark>
          .UseStartup<Startup>()
          .Build();
}
</pre></code>
ASP.NET Core 2.x Default Builder