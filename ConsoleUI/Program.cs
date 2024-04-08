using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Todo: Follow all comments!! 
* Double click on the region (gray box) to view all comments
*/

#region Vehicles

/*
 * Create an abstract class called Vehicle
 * The vehicle class shall have three string properties: Year, Make, and Model
 * Set the defaults of the properties to something generic in the Vehicle class
 * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
 * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
 */

/* 
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
*/

// Create a list of Vehicle called vehicles

List<Vehicle> vehicles = new List<Vehicle>();

/*
 * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes

 * 
 * Set the properties values with object initializer syntax
 */
var car1 = new Car()
{
    HasTrunk = true,
    Year = "2005",
    Make = "Honda",
    Model = "Civic"
};
var motorcycle = new Motorcycle()
{
    HasSideCar = true,
    Year = "2020",
    Make = "Motorcycle",
    Model = "Cool"
};
Vehicle vehicle = new Car()
{
    HasTrunk = true,
    Year = "2012",
    Make = "Ford",
    Model = "Fusion"
};
Vehicle vehicle1 = new Motorcycle()
{
    HasSideCar = true,
    Year = "2023",
    Make = "Kia",
    Model = "Optima"

};

vehicles.Add(vehicle);
vehicles.Add(vehicle1);
vehicles.Add(car1);
vehicles.Add(motorcycle);

foreach (var Vehicle in vehicles)
{
    Console.WriteLine("");
    Console.WriteLine("Car details");
    Console.WriteLine($"Year: {Vehicle.Year}");
    Console.WriteLine($"Make: {Vehicle.Make}");
    Console.WriteLine($"Model: {Vehicle.Model}");
    
    Vehicle.DriveVirtual();
    Vehicle.DriveAbstract();
}


/*
 * Add the 4 vehicles to the list
 * Using a foreach loop iterate through the list and display each of the properties
 */

// Call each of the drive methods for one car and one motorcycle

#endregion

