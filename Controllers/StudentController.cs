using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Net_Core_API.Models;


namespace Net_Core_API.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
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
    [HttpPost]
    public IActionResult Index(string FullName , String ID ,String Age,string Address)
    {
        string strOutput = "xin chào  " + ID + "-" +FullName +"-" + Age + "-" + Address;
        ViewBag.Message = strOutput;
        return View();
    }
}
