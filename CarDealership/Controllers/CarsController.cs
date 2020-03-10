using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }


    [HttpPost("/cars/add")]
    public ActionResult CreateForm(string description, string makeModel, int price, int miles)
    {
      Car newCar = new Car(description, makeModel, price, miles);
      return View();
    }
  }
}