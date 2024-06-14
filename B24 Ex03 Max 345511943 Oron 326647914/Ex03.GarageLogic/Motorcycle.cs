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
