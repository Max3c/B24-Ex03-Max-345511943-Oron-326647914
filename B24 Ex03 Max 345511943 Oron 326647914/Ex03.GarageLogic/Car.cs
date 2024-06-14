public class Car : Veichle 
{
    private CarColor m_color;
    private int m_doors;

    // Constructor
    public Car(string i_modelName, string i_licenseNumber, float i_remainingEnergy, List<Wheel> i_wheels, CarColor i_carColor, int i_numDoors) : base(modelName, licenseNumber, remainingEnergy, wheels)
    {
        m_color = carColor;
        m_doors = numDoors;
    }  
}

public class ElectricCar : Car, IElectricVeichle
{
    private float m_RemainingEngineTime;
    private float m_MaxEngineTime;

    public ElectricCar(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, CarColor carColor, int numDoors, float remainingEngineTime, float maxEngineTime) : base(modelName, licenseNumber, remainingEnergy, wheels, carColor, numDoors)
    {
        m_RemainingEngineTime = remainingEngineTime;
        m_MaxEngineTime = maxEngineTime;
    }

    public void Recharge(float hours)
    {
        if (m_RemainingEngineTime + hours <= m_MaxEngineTime)
        {
            m_RemainingEngineTime += hours;
        }
    }
}

public class FuelCar : Car, IFuelVehicle
{
    private FuelType m_FuelType;
    private float m_RemainingFuelLiters;
    private float m_MaxAmountOfFuel;

    public FuelCar(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, CarColor carColor, int numDoors, FuelType fuelType, float remainingFuelLiters, float maxAmountOfFuel) : base(modelName, licenseNumber, remainingEnergy, wheels, carColor, numDoors)
    {
        m_FuelType = fuelType;
        m_RemainingFuelLiters = remainingFuelLiters;
        m_MaxAmountOfFuel = maxAmountOfFuel;
    }

    public void Refuel(float i_Amount, FuelType i_FuelType)
    {
        if (m_RemainingFuelLiters + i_Amount <= m_MaxAmountOfFuel)
        {
            m_RemainingFuelLiters += i_Amount;
        }
    }
}