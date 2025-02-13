//Derived class (child)
public class Car : Vehicle
{
   public int Seats{get; set;}

   public void ShowCarInfo()
   {
    Console.WriteLine($"Brand: {Brand}, Speed : {Speed} km/h, Seats : {Seats}");
   }
}