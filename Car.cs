using System;
using System.Collections.Generic;

public class Car
{
  //New constructor code below.
  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }
  public string MakeModel;
  public int Price;
  public int Miles;

  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}
