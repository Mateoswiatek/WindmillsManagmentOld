using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using windmillsManagement.Models;

namespace windmillsManagement.Controllers;

public class WindmillController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public WindmillController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("windmills/{guid}")]
    public IActionResult Windmill(Guid guid)
    {
        _logger.LogInformation("guid: {}", guid);
        return View();
    }
    
    [Route("windmills")]
    public IActionResult WindmillList(int? page, int? size)
    {
        _logger.LogInformation("tutaj będzie sobie lista , page: {}, size: {}", page, size);
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}