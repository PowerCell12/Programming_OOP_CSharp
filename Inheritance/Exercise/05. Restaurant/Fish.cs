namespace Restaurant;


public class Fish: MainDish{



    public  const int grams = 22;

    public Fish(string name, decimal price): base(name, price, grams){
    }


}