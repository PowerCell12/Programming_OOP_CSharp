using System.Net.Http.Headers;

public class Person{

    private string name;
    private decimal money;


    public Person(string name, decimal money){
        Name = name;
        Money = money;
        products = new List<Product>();
    }

    public string Name{get{return name;}  set{

        if (string.IsNullOrWhiteSpace(value)){
            throw new Exception("Name cannot be empty");
        }

        name = value;


    }}

    public decimal Money {get{return money;}  set{ 

        if (value < 0){

            throw new Exception("Money cannot be negative");

        }

        money = value;

    }}

    public  List<Product> products;



}