using System.Diagnostics;

namespace entities;

/// <summary>
/// Represents a country entity.
/// </summary>
[DebuggerDisplay("{Name,nq}")]
public class Country
{
    public Country()
    {
        States = new List<State>();

    }

    /// <summary>
    /// Gets or sets the unique identifier for the country.
    /// </summary>
    public int Id { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the name of the country.
    /// </summary>
    public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the ISO 3166-1 alpha-3 code of the country.
    /// </summary>
    public string Iso3 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the ISO 3166-1 alpha-2 code of the country.
    /// </summary>
    public string Iso2 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the ISO 3166-1 numeric code of the country.
    /// </summary>
    public string NumericCode { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the phone code of the country.
    /// </summary>
    public string PhoneCode { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the capital city of the country.
    /// </summary>
    public string Capital { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the currency used in the country.
    /// </summary>
    public Currency Currency { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the region (continent) to which the country belongs.
    /// </summary>
    public Region Region { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the geographical location (latitude and longitude) of the country.
    /// </summary>
    public GeoLocation GeoLocation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    public ICollection<State> States { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}