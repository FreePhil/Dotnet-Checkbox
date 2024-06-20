using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        var hobbies = new List<HobbyModel>
        {
            new HobbyModel { Name = "Jogging" },
            new HobbyModel { Name = "Football" },
            new HobbyModel { Name = "Basketball" },
            new HobbyModel { Name = "Swimming" },
            new HobbyModel { Name = "Baseball" }
        };
        ViewBag.Hobbies = hobbies;
        return View();
    }

    [HttpPost]
    public ActionResult Submit(UserModel userModel)
    {
        var hobbies = new List<HobbyModel>
        {
            new HobbyModel { Name = "Jogging" },
            new HobbyModel { Name = "Football" },
            new HobbyModel { Name = "Basketball" },
            new HobbyModel { Name = "Swimming" },
            new HobbyModel { Name = "Baseball" }
        };
        ViewBag.Hobbies = hobbies;
        return View("Index", userModel);
    }

    public ActionResult Success()
    {
        return View();
    }
}
