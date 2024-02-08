using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


namespace Shapes;

public class StartUp {
  static void Main()
  {

    List<string> final = Console.ReadLine().Split().ToList();
    List<string> final1 = Console.ReadLine().Split().ToList();
    List<string> fianl5 = Console.ReadLine().Split().ToList();


    Car car = new Car(double.Parse(final[1]), double.Parse(final[2]), double.Parse(final[3]));
    Truck truck = new Truck(double.Parse(final1[1]), double.Parse(final1[2]), double.Parse(final1[3]));
    Bus bus = new Bus(double.Parse(fianl5[1]), double.Parse(fianl5[2]), double.Parse(fianl5[3]));

  
    int lines = int.Parse(Console.ReadLine());

    for(int i = 0; i < lines; i++){

      List<string> final3= Console.ReadLine().Split().ToList();

      if (final3[0] == "Drive"){

        if (final3[1] == "Car"){
          car.Drive(double.Parse(final3[2]));
        }
        else if (final3[1] == "Truck"){
          truck.Drive(double.Parse(final3[2]));
        }
        else{
          bus.Drive(double.Parse(final3[2]));
        }


      }
      else if (final3[0] == "Refuel"){

        if (final3[1] == "Car"){
          car.Refuel(double.Parse(final3[2]));
        }
        else if(final3[1] == "Truck"){
          truck.Refuel(double.Parse(final3[2]));
        }
        else{
          bus.Refuel(double.Parse(final3[2]));
        }





      }

      if (final3[0] == "DriveEmpty"){
        bus.DriveWithoutPeople(double.Parse(final3[2]));
      }

    }


    Console.WriteLine($"Car: {car.FuelQuantity:f2}\nTruck: {truck.FuelQuantity:f2}\nBus: {bus.FuelQuantity:f2}");




  }
}
