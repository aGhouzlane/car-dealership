namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private bool _engine;

    public Car(string makeModel, int price, int miles, bool engine)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _engine = engine;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    publix

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }

}
