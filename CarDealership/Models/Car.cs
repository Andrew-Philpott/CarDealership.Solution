namespace CarDealership.Models {
  public class Car
  {

    public string Description {get;set;}
    public string MakeModel {get; set;}
    public int Price {get;set;}
    public int Miles {get;set;}
    private static List<Cars> _cars = new List<Cars>();

    public Car(string description, string makeModel, int price, int miles)
    {
      Description = description;
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _cars.Add(this);
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