using System;
using System.Linq.Expressions;

namespace PersonsInfo;


public class StartUp {
  static void Main()
  {
    try{
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Box box = new Box(length, width, height);


        double surface_area =box.SurfaceArea();
        double lateral = box.LateralSurfaceArea();
        double volume = box.Volume();

        Console.WriteLine($"Surface Area - {surface_area:f2}");
        Console.WriteLine($"Lateral Surface Area - {lateral:f2}");
        Console.WriteLine($"Volume - {volume:f2}");  
    }
    catch(ArgumentException ex){
      Console.WriteLine(ex.Message);
    }



  }
}
