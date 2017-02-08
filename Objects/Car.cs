
using System.Collections.Generic;

namespace CarSales.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<string> _instances = new List<string> {};

    public Car (string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

      public void SetMakeModel(string newMakeModel)
      {
        _makeModel = newMakeModel;
      }
      public string GetMakeModel()
      {
        return _makeModel;
      }
      public void SetPrice(int newPrice)
      {
        _price = newPrice;
      }
      public int GetPrice()
      {
        return _price;
      }
      public void SetMiles(int newMiles)
      {
        _miles = newMiles;
      }
      public int GetMiles()
      {
        return _miles;
      }

      public static List<string, int, int> GetAll()
      {
        return _instances;
      }
      public void Save()
      {
      _instances.Add(_makeModel, _price, _miles);
    }
  }
}
