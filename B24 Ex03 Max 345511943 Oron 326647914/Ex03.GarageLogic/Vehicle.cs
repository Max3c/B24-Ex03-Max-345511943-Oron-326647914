﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    public interface IElectricVehicle
    {
        float RemainingEngineTime { get; }
        float MaxEngineTime { get; }
        void Recharge(float hours);
    }
    public interface IFuelVehicle
    {
        FuelType FuelType { get; }
        float RemainingFuelLiters { get; }
        void Refuel(float i_Amount, FuelType i_FuelType);
    }
    /// <summary>
    ///  every vehicle contains the following properties:
    ///  Model Name(String),License Number(String),Remaining Energy Percentage(Fuel/Battery) (float),Wheels, with each wheel containing the following:
    /// </summary>
   
    internal class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_RemainingEnergy;
        public List<Wheel> m_Wheels {  get; set; }
        public string m_OwnerName { get; set; }
        public string m_OwnerPhoneNumber { get; set; }
        public VehicleStatus m_Status { get; set; } = VehicleStatus.InRepair;
        public string ModelName
        {
            get { return m_ModelName; }
            set { m_ModelName = value; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
            set { m_LicenseNumber = value; }
        }

        public float RemainingEnergy
        {
            get { return m_RemainingEnergy; }
            set { m_RemainingEnergy = value; }
        }

        public Vehicle(string i_modelName, string i_licenseNumber, float i_remainingEnergy, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            m_ModelName = i_modelName;
            m_LicenseNumber = i_licenseNumber;
            m_RemainingEnergy = i_remainingEnergy;
            m_Wheels = new List<Wheel>();
            m_OwnerName = i_OwnerName;
            m_OwnerPhoneNumber = i_OwnerPhoneNumber;
            m_Status = VehicleStatus.InRepair;
        }
    }
}
