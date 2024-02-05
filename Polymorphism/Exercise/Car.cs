public class Car : Vehicle
{

    public Car(double fuelquantity, double fuelconsumption): base(fuelquantity, fuelconsumption + 0.9){

    }


    public override void Drive(double kilometers)
    {
        if (FuelQuantity - kilometers * FuelConsumption >=0){
            FuelQuantity -= kilometers * FuelConsumption;
            Console.WriteLine($"Car travelled {kilometers} km");
        }
        else{
            Console.WriteLine($"Car needs refueling");    
        }
    }


    public override void Refuel(double liters)
    {
       
        FuelQuantity += liters;

        

    }
}