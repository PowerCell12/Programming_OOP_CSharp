using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


namespace Shapes;

public class StartUp {
  static void Main()
  {

    try{

      int number = int.Parse(Console.ReadLine());

      if(number < 0){
        throw new Exception();
      }

      Console.WriteLine(Math.Sqrt(number));

    }
    catch(Exception exception){
      Console.WriteLine("Invalid number.");

    }
    finally{
      Console.WriteLine("Goodbye.");
    }

  
  }
}
