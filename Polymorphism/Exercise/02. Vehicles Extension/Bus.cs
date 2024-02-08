public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankcapacity) : base(fuelQuantity, fuelConsumption, tankcapacity)
    {
    }


    public override void Drive(double kilometers)
    {

        FuelConsumption += 1.4;

        if (FuelQuantity - kilometers * FuelConsumption >=0){
            FuelQuantity -= kilometers * FuelConsumption;
            Console.WriteLine($"Bus travelled {kilometers} km");
        }
        else{
            Console.WriteLine($"Bus needs refueling");    
        }




        FuelConsumption -= 1.4;
        
    }

    public void DriveWithoutPeople(double kilometers){

        if (FuelQuantity - kilometers * FuelConsumption >=0){
            FuelQuantity -= kilometers * FuelConsumption;
            Console.WriteLine($"Bus travelled {kilometers} km");
        }
        else{
            Console.WriteLine($"Bus needs refueling");    
        }

    }


    public override void Refuel(double liters)
    {
    
        if (liters <= 0){
            Console.WriteLine("Fuel must be a positive number");
        }
        else{

            double litersFinal = liters;
            if (FuelQuantity + litersFinal > TankCapacity){
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else{
        
                FuelQuantity += litersFinal;
            }
        }






    }
}