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

    Console.WriteLine(ReadNumber(1, 100));
    

  
  }


  public static string ReadNumber(int start, int end){

    List<int> numbers = new List<int>();

    while (true){

      if (numbers.Count  == 10){
          break;
      }

      try{



        int number = int.Parse(Console.ReadLine());

        if (numbers.Count > 0){
          if (number <= numbers[numbers.Count -1 ] || number >= 100 ){
            throw new ArgumentException();
          }
        }
        else{
           if (number <= 1 || number >= 100 ){
            throw new ArgumentException();
          }
        }


        numbers.Add(number);

      }
      catch(FormatException){
        Console.WriteLine("Invalid Number!");
      }
      catch(ArgumentException){
        if (numbers.Count > 0){
          Console.WriteLine($"Your number is not in range {numbers[numbers.Count -1]} - {end}!");
        }
        else{  Console.WriteLine($"Your number is not in range {start} - {end}!");}
      }


    }

    return string.Join(", ", numbers);



  }
}
