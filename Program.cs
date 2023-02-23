namespace Teste.Gateway
{
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((host, config) =>
        {
            config.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
        }).ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
    }
}