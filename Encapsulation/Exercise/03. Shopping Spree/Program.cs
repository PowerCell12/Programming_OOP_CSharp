using System;
using System.IO.Compression;
using System.Linq.Expressions;

namespace PersonsInfo;


public class StartUp {
  static void Main()
  {


    List<Person> all_people = new List<Person>();
    List<string> people = Console.ReadLine().Split(";").ToList();

    foreach(var thing in people){

     if (thing == string.Empty){
      break;
     } 

      List<string> final = thing.Split("=").ToList();


      if (final.Count > 1){
        try{
            Person person = new Person(final[0], decimal.Parse(final[1]));
    
            all_people.Add(person);
    
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
    }

    }


    List<Product> all_products = new List<Product>();
    List<string> products = Console.ReadLine().Split(";").ToList();

    foreach(var thing in products){

      List<string> final1 = thing.Split("=").ToList();

      if (final1.Count > 1){
        try{
            Product product = new Product(final1[0], decimal.Parse(final1[1]));
            all_products.Add(product);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
      
      }

    }


    while(true){

      List<string> person_product = Console.ReadLine().Split().ToList();

      if (person_product[0] == "END"){

        foreach(var person2 in all_people){

          if (person2.products.Count == 0){
              Console.WriteLine($"{person2.Name} - Nothing bought ");
          }
          else{
            Console.WriteLine($"{person2.Name} - {string.Join(", ", person2.products.Select(x => x.Name))}");
          }
        }


        break;
      } 


      Person person  = all_people.Find(x => x.Name == person_product[0]);
      Product product = all_products.Find(x => x.Name == person_product[1]);

      if (person.Money < product.Cost){
        Console.WriteLine($"{person.Name} can't afford {product.Name}");
      }
      else{
        person.products.Add(product);
        person.Money -=  product.Cost;
        Console.WriteLine($"{person.Name} bought {product.Name}");
      }



    }




  }
}
