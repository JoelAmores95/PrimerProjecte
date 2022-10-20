using Microsoft.AspNetCore.Mvc;
// Dice que es importante que es ASPNET CORE

namespace PrimerProjecte.Controllers;

[ApiController]
[Route("[controller]")]

// Hereda de una clase, solo una. Tantas interficies como quiera
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

// Patron de inyeccion de dependencias, crea el minimo de instancias posibles, por eso se crea DENTRO del constructor
    private readonly ILogger<WeatherForecastController> _logger;

    // Esta depende de la de arriba
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpPost]
    public void Post([FromBody] WeatherForecast forecast)
    {
        _logger.LogInformation(forecast.ToString());
    }
   
}
