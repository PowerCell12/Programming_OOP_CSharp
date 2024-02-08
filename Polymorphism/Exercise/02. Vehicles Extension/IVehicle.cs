public interface IVehicle{

    double FuelQuantity{get;}

    double FuelConsumption {get;}

    double TankCapacity{get;}

    void Drive(double kilometers);

}