using System.Diagnostics;
namespace entities;

/// <summary>
/// Represents a geographical location with latitude and longitude coordinates.
/// </summary>
[DebuggerDisplay("Latitude: {Latitude}, Longitude: {Longitude}")]
public class GeoLocation
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeoLocation"/> class with the specified latitude and longitude.
    /// </summary>
    /// <param name="latitude">The latitude coordinate.</param>
    /// <param name="longitude">The longitude coordinate.</param>
    public GeoLocation(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    /// <summary>
    /// Gets or sets the latitude coordinate.
    /// </summary>
    public double Latitude { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the longitude coordinate.
    /// </summary>
    public double Longitude { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}