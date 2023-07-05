using System.Diagnostics;

namespace entities;

/// <summary>
/// Represents a city entity.
/// </summary>
[DebuggerDisplay("{Name,nq}")]
public class City
{
    /// <summary>
    /// Gets or sets the unique identifier of the city.
    /// </summary>
    public int Id { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the name of the city.
    /// </summary>
    public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the geographical location of the city. It can be null.
    /// </summary>
    public GeoLocation? GeoLocation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}