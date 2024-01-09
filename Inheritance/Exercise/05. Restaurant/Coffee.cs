namespace Restaurant;


public class Coffee: HotBeverage{

    public Coffee(string name, double caffeine): base(name, CoffeePrice, CoffeeMilliliters){
        Caffeine = caffeine;
    }


    public double Caffeine {get; set;}

    public const double CoffeeMilliliters = 50;


    public const decimal CoffeePrice = 3.50M;

}