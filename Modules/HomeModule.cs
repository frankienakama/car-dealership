using Nancy;
using CarSales.Objects;
using System.Collections.Generic;

namespace CarSales
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/car_list"] = _ => {
        List<string> allCars = Car.GetAll();
        return View["car_list.cshtml", allCars];
    };
  //   Post["/car_list"] = _ => {
  //     Car newCar = new Car (Request.Form["make-model", "price", "miles"]);
  //     newCar.Save();
  //     return View["car_list.cshtml", newCar];
  //   };
    }
  }
}
