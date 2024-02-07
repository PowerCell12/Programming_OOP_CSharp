public class Truck : Vehicle
{

    public Truck(double fuelquantity, double fuelconsumption): base(fuelquantity, fuelconsumption + 1.6){

    }


    public override void Drive(double kilometers)
    {
        if (FuelQuantity - kilometers * FuelConsumption >=0){
            FuelQuantity -= kilometers * FuelConsumption;
            Console.WriteLine($"Truck travelled {kilometers} km");
        }
        else{
            Console.WriteLine($"Truck needs refueling");    
        }
    }


    public override void Refuel(double liters)
    {


        double litersFinal = liters * 0.95;

        FuelQuantity += litersFinal;

       
    }
}