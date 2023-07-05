using System.Diagnostics;

namespace entities;

/// <summary>
/// Represents a state entity.
/// </summary>
[DebuggerDisplay("{Name,nq}")]
public class State
{
    /// <summary>
    /// Gets or sets the unique identifier of the state.
    /// </summary>
    public int Id { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the name of the state.
    /// </summary>
    public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the code representing the state.
    /// </summary>
    public string Code { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the type of the state. It can be null.
    /// </summary>
    public string? Type { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the geographical location of the state. It can be null.
    /// </summary>
    public GeoLocation? GeoLocation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}