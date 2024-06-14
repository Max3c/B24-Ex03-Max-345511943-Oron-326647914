using System;
using Enums;
public class Motorcycle : Vehicle
{
    public LicenseType LicenseType { get; set; }
    public int EngineVolume { get; set; }

    public Motorcycle(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, LicenseType licenseType, int engineVolume) : base(modelName, licenseNumber, remainingEnergy, wheels)
    {
        LicenseType = licenseType;
        EngineVolume = engineVolume;
    }
}

public class ElectricMotorcycle : Motorcycle , IElectricVeichle
{
    private float m_RemainingEngineTime;
    private float m_MaxEngineTime;

    public ElectricMotorcycle(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, LicenseType licenseType, int engineVolume, float remainingEngineTime, float maxEngineTime) : base(modelName, licenseNumber, remainingEnergy, wheels, licenseType, engineVolume)
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

public class FuelMotorcycle : Motorcycle, IFuelVehicle
{
    private FuelType m_FuelType;
    private float m_RemainingFuelLiters;
    private float m_MaxAmountOfFuel;

    public FuelMotorcycle(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, LicenseType licenseType, int engineVolume, FuelType fuelType, float remainingFuelLiters, float maxAmountOfFuel) : base(modelName, licenseNumber, remainingEnergy, wheels, licenseType, engineVolume)
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
