using Glovebox.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Glovebox.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    [HttpGet(Name = "GetVehicles")]
    public ActionResult<IEnumerable<Vehicle>> Get()
    {
        var vehicles = new List<Vehicle>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Nickname = "The Daily",
                Type = VehicleType.Car,
                Make = "Volkswagen",
                Model = "Golf",
                Year = 2018,
                FuelType = FuelType.Petrol,
                Transmission = Transmission.Manual
            }
        };

        return Ok(vehicles);

    }

}