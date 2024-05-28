using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using windmillsManagement.Models;

namespace windmillsManagement.Controllers;

public class WindmillController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // wyświetlenie wszystkich windparków po parametrach "lokalizacji"
    // np będziemy mieli osadzoną mapę, i dostaniemy zakresy szerokości i długości.
    // user może też określić max ilość wiatraków, tak aby nie ładowało się za kazdym razem.
    
    // po prostu zrobimy wyszukiwanie z filtrem. i w tedy w windparkach, będziemy zwracać efekt takiego
    // wyszukania, gdzie windpark==this.
    
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
    
    //https://localhost:7214/windmills?page=2&size=20
    [Route("windmills")]
    public IActionResult WindmillList(int? page, int? size)
    {
        _logger.LogInformation("tutaj będzie sobie lista , page: {}, size: {}", page, size);
        
        //Tutaj np będzie zwracana również nazwa windparku / numer, i po nim bedzie przekierowanie, choc to to 
        // już po stornie fronta można zorbić.
        
        return View();
        
        // int pageNumber = page ?? 0;
        // int currentPageSize = pageSize ?? 10; // Domyślna wielkość strony (jeśli nie podano przez użytkownika)
        //
        // // Pobierz wiatraki tylko dla danej strony
        // var pagedWindmills = _windmillService.GetPagedWindmills(pageNumber, currentPageSize);
        //
        // // Zaloguj informacje o stronnicowaniu
        // _logger.LogInformation($"Wyświetlono stronę {pageNumber} z wiatrakami (pageSize: {currentPageSize})");
        //
        // // Przekaż stronnicowaną listę do widoku
        // return View(pagedWindmills);
    }

    public IActionResult Redirect()
    {
        return RedirectToAction("WindmillList");
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}