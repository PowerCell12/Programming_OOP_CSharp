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


    Car car = new Car(double.Parse(final[1]), double.Parse(final[2]));
    Truck truck = new Truck(double.Parse(final1[1]), double.Parse(final1[2]));

    int lines = int.Parse(Console.ReadLine());

    for(int i = 0; i < lines; i++){

      List<string> final3= Console.ReadLine().Split().ToList();

      if (final3[0] == "Drive"){

        if (final3[1] == "Car"){
          car.Drive(double.Parse(final3[2]));
        }
        else{
          truck.Drive(double.Parse(final3[2]));
        }


      }
      else if (final3[0] == "Refuel"){

        if (final3[1] == "Car"){
          car.Refuel(double.Parse(final3[2]));
        }
        else{
          truck.Refuel(double.Parse(final3[2]));
        }




      }


    }

    Console.WriteLine($"Car: {car.FuelQuantity:f2}\nTruck: {truck.FuelQuantity:f2}");




  }
}
