using System;
using System.Collections.Generic;

public abstract class Person : IPersonService
{
    // Encapsulation: Properties for Name, DateOfBirth, and Salary encapsulate the person's information.
    // 'Salary' is protected to limit access and can be modified only within the class or derived classes.
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal Salary { get; protected set; }

    // Encapsulation: A private List that stores addresses, and it's not directly accessible from outside the class.
    // Provides controlled access through methods.
    private List<string> addresses = new List<string>();

    // Constructor: The constructor is used to initialize a new instance of the Person class. 
    // Encapsulation ensures that Salary cannot be negative when set.
    public Person(string name, DateTime dob, decimal salary)
    {
        Name = name;
        DateOfBirth = dob;
        Salary = salary < 0 ? 0 : salary; // Ensuring salary is not negative.
    }

    // Encapsulation: This method calculates the age based on the DateOfBirth.
    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    // Polymorphism: This is a virtual method that can be overridden in derived classes. 
    // It calculates and returns the salary. This provides flexibility in how salary is calculated in subclasses.
    public virtual decimal CalculateSalary()
    {
        return Salary; // Default salary calculation
    }

    // Encapsulation: Allows adding addresses for the person. 
    // The list of addresses is hidden and controlled through this method.
    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    // Encapsulation: Retrieves the list of addresses, providing controlled access.
    public List<string> GetAddresses()
    {
        return addresses;
    }

    // Abstraction: This abstract method forces derived classes to provide an implementation of DisplayInfo.
    // It defines a common interface for displaying a person's information but leaves the implementation up to subclasses.
    public abstract void DisplayInfo(); // Abstract method for polymorphism
}
