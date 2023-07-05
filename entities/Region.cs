using System.Diagnostics;
namespace entities;

/// <summary>
/// Represents a geographical region.
/// </summary>
[DebuggerDisplay("{Name,nq}")]
public class Region
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Region"/> class with the specified name and subregion.
    /// </summary>
    /// <param name="name">The name of the region.</param>
    /// <param name="subregion">The subregion or subarea of the region.</param>
    public Region(string name, string subregion)
    {
        Name = name;
        Subregion = subregion;
    }

    /// <summary>
    /// Gets or sets the name of the region.
    /// </summary>
    public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the subregion or subarea of the region.
    /// </summary>
    public string Subregion { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}