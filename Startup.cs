using System.Reflection;

/// <summary>
/// Represents the startup class for the application.
/// </summary>
public class Startup
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Startup"/> class.
    /// </summary>
    /// <param name="configuration">The application configuration.</param>
    public Startup(IConfiguration configuration)
    {
        // Initialization logic, if any.
    }

    /// <summary>
    /// Gets the application configuration.
    /// </summary>
    /// <remarks>
    /// The application configuration contains key-value pairs of settings
    /// used throughout the application. It is typically populated from various
    /// sources such as appsettings.json, environment variables, command-line arguments, etc.
    /// </remarks>
    public IConfiguration Configuration { get; }

    /// <summary>
    /// Configures the application services.
    /// </summary>
    /// <param name="services">The service collection to configure.</param>
    /// <remarks>
    /// This method is used to configure the application services. It is called during the application startup,
    /// and here you can register various services, dependencies, and options with the dependency injection container.
    /// </remarks>
    public void ConfigureServices(IServiceCollection services)
    {
        // Add controllers and endpoint routing.
        services.AddControllers();
        services.AddEndpointsApiExplorer();
    }

    /// <summary>
    /// Configures the application pipeline.
    /// </summary>
    /// <param name="app">The application builder.</param>
    /// <param name="env">The web host environment.</param>
    /// <remarks>
    /// This method is used to configure the application request pipeline. It is called during the application startup,
    /// and here you can specify how the application should handle incoming HTTP requests and responses.
    /// </remarks>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Use developer exception page if running in development environment.
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // Use routing middleware.
        app.UseRouting();

        // Use endpoint middleware to handle incoming requests.
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}