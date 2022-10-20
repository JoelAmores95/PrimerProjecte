using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace PrimerProjecte.Controllers;


[ApiController]
[Route("[controller]")]
public class CounterController : ControllerBase
{
    private readonly ICounterService counterService;
    public CounterController(ICounterService counterService)
    {
        this.counterService = counterService;
    }

    [HttpGet]
    public int GetCount()
    {
        return counterService.getAddIncrement();
    }
}