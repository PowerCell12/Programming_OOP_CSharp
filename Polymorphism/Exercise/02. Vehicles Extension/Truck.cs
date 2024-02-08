public class Truck : Vehicle
{

    public Truck(double fuelquantity, double fuelconsumption, double TankCapacity): base(fuelquantity, fuelconsumption + 1.6, TankCapacity){

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

        if (liters <= 0){
            Console.WriteLine("Fuel must be a positive number");
        }
        else{
            double litersFinal = liters * 0.95;
            if (FuelQuantity + litersFinal > TankCapacity){
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else{
        
                FuelQuantity += litersFinal;
            }
        }
       
    }
}