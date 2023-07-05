using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using infrastructure.databases;

/// <summary>
/// The entry point class for the application.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">The command-line arguments passed to the application.</param>
    public static async Task Main(string[] args)
    {
        // Create the host builder with default configurations.
        IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                // Specify the startup class for the web host.
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureLogging(loggerBuilder =>
            {
                // Configure logging to use a simple console logger with custom settings.
                loggerBuilder.ClearProviders()
                    .AddSimpleConsole(_ =>
                    {
                        _.TimestampFormat = "[dd/MM/yy HH:mm:ss:fff] ";
                        _.IncludeScopes = true;
                    });
            })
            .ConfigureServices(services =>
            {
                // Configure the application's services, including the database context.
                var connectionstring = Environment.GetEnvironmentVariable("CONNECTION_STRING")?.Replace("\"", "");
                if (String.IsNullOrEmpty(connectionstring))
                    throw new InvalidOperationException("CONNECTION_STRING environment variable not found");

                // Register the DataContext with Npgsql as the PostgreSQL provider.
                services.AddDbContext<DataContext>(
                    options => options.UseNpgsql(connectionstring)
                                      .UseSnakeCaseNamingConvention()
                                      .EnableSensitiveDataLogging());
            })
            .Build();

        // Run the application.
        await host.RunAsync();
    }
}