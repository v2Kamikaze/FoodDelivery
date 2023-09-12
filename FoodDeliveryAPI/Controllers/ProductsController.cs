using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAPI.Controllers;

[ApiController]
[Route("api")]
public class ProductsController : ControllerBase
{
    // GET
    [HttpGet("v1/products")]
    public IActionResult Index()
    {
        return Ok();
    }
}