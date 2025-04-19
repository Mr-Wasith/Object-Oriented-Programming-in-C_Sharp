/*
Task 1: Home Automation System
==============================

Create an Interface IDevice:

Methods: void TurnOn(), void TurnOff()
Create an Interface ISmart:

Methods: void ConnectToWifi(), void DisconnectFromWifi()
Create an Abstract Class Device:

Implements IDevice.
Properties: string Name, string Brand
Abstract methods: TurnOn(), TurnOff()
Concrete method: GetDeviceInfo() to display device details.
Create Derived Classes:

SmartLight (Implements TurnOn(), TurnOff(), and ISmart interface)
SmartThermostat (Implements TurnOn(), TurnOff(), and ISmart interface)
Main Method:

Create instances of SmartLight and SmartThermostat.
Demonstrate polymorphism with IDevice and call their methods.

 */

using System;

// Interface for Device operations
interface IDevice
{
    void TurnOn();
    void TurnOff();
}

// Interface for Smart capabilities
interface ISmart
{
    void ConnectToWifi();
    void DisconnectFromWifi();
}

// Abstract class for common device properties and behavior
abstract class Device : IDevice
{
    public string Name { get; set; }
    public string Brand { get; set; }

    public Device(string name, string brand)
    {
        Name = name;
        Brand = brand;
    }

    // Abstract methods to be implemented by derived classes
    public abstract void TurnOn();
    public abstract void TurnOff();

    // Concrete method to display device info
    public void GetDeviceInfo()
    {
        Console.WriteLine($"Device: {Name}, Brand: {Brand}");
    }
}

// Derived class for SmartLight
class SmartLight : Device, ISmart
{
    public SmartLight(string name, string brand) : base(name, brand) { }

    public override void TurnOn()
    {
        Console.WriteLine($"{Name} is turned on.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Name} is turned off.");
    }

    public void ConnectToWifi()
    {
        Console.WriteLine($"{Name} is connected to Wifi.");
    }

    public void DisconnectFromWifi()
    {
        Console.WriteLine($"{Name} is disconnected from Wifi.");
    }
}

class SmartThermostat : Device, ISmart
{
    public SmartThermostat(string name, string brand) : base(name, brand) { }

    public override void TurnOn()
    {
        Console.WriteLine($"{Name} is heating/cooling.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Name} is off.");
    }

    public void ConnectToWifi()
    {
        Console.WriteLine($"{Name} is connected to Wifi.");
    }

    public void DisconnectFromWifi()
    {
        Console.WriteLine($"{Name} is disconnected from Wifi.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of SmartLight and SmartThermostat
        SmartLight light = new SmartLight("Living Room Light", "Philips");
        SmartThermostat thermostat = new SmartThermostat("Nest Thermostat", "Google");

        // Using IDevice methods
        light.GetDeviceInfo();
        light.TurnOn();
        light.ConnectToWifi();
        light.DisconnectFromWifi();
        light.TurnOff();

        Console.WriteLine(); // Line break for clarity

        thermostat.GetDeviceInfo();
        thermostat.TurnOn();
        thermostat.ConnectToWifi();
        thermostat.DisconnectFromWifi();
        thermostat.TurnOff();
    }
}
