namespace CarDealership.Models {
  public class Car
  {
    public string Description;
    public string MakeModel;
    public int Price;
    public int Miles;

    public Car(string description, string makeModel, int price, int miles)
    {
      Description = description;
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }
    public bool WorthBuying(int maxPrice, int miles)
    {
      if((Price < maxPrice) && (Miles < miles)) {
        return true;
      } else {
        return false;
      }
    }
  }
}