public class Car : Vehicle
{

    public Car(double fuelquantity, double fuelconsumption, double TankCapacity): base(fuelquantity, fuelconsumption + 0.9, TankCapacity){

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

        if (liters <= 0){
            Console.WriteLine("Fuel must be a positive number");
        }
        else{
            if (FuelQuantity + liters > TankCapacity){
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else{
        
                FuelQuantity += liters;
            }
        }

    }
}