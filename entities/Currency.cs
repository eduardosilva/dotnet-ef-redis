using System.Diagnostics;
namespace entities;

/// <summary>
/// Represents a currency entity.
/// </summary>
[DebuggerDisplay("{Name,nq}")]
public class Currency
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Currency"/> class.
    /// </summary>
    /// <param name="code">The currency code (e.g., USD, EUR).</param>
    /// <param name="name">The name of the currency (e.g., United States Dollar, Euro).</param>
    /// <param name="symbol">The currency symbol (e.g., $, €).</param>
    public Currency(string code, string name, string symbol)
    {
        Code = code;
        Name = name;
        Symbol = symbol;
    }

    /// <summary>
    /// Gets or sets the currency code (e.g., USD, EUR).
    /// </summary>
    public string Code { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the name of the currency (e.g., United States Dollar, Euro).
    /// </summary>
    public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Gets or sets the currency symbol (e.g., $, €).
    /// </summary>
    public string Symbol { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}