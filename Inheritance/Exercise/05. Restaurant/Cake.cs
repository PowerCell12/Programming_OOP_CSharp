namespace Restaurant;

public class Cake: Dessert{


    public const double grams = 250;

    public const double calories = 1000;

    public const decimal cake_price = 5;

    public Cake(string name): base(name, cake_price, grams, calories){
    }




}