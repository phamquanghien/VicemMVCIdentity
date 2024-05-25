using System.Diagnostics;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using VicemMVCIdentity.Models;

namespace VicemMVCIdentity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IDataProtector _protector;

    public HomeController(IDataProtectionProvider provider)
    {
        _protector = provider.CreateProtector("");
    }
    public string ProtectData(string input)
    {
        return _protector.Protect(input);
    }
    public string UnprotectData(string protectedData)
    {
        return _protector.Unprotect(protectedData);
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
