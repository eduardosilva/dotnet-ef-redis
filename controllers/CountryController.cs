using entities;
using infrastructure.databases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace controllers;

[Route("api/{controller}")]
[ApiController]
public class CountryController : ControllerBase
{
    public DataContext DataContext { get; }
    public CountryController(DataContext datacontext)
    {
        DataContext = datacontext;

    }

    [HttpGet()]
    public async Task<IEnumerable<Country>> Index()
    {
        var result = await DataContext.Countries.ToArrayAsync();
        return result;
    }
}
