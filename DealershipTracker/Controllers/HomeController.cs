using DealershipTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DealershipTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {

      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [Route("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/updatedindex")]
    public ActionResult Create(string brand)
    {
      Car myCar = new Car(brand);
      return RedirectToAction("Index");
    }

  }
}