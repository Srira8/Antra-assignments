using System;

namespace UniversityManagementSystem
{
    // Inheritance: Instructor inherits from Person, gaining properties and methods from the base class.
    // Implements Interface: Instructor also implements IInstructorService to define specific behaviors.
    public class Instructor : Person, IInstructorService
    {
        // Encapsulation: Properties with public getters and setters.
        public DateTime JoinDate { get; set; }
        public Department Department { get; set; } // Association: Instructor is linked to a Department.

        // Constructor: Uses base keyword to call the constructor of the parent class (Person).
        public Instructor(string name, DateTime dob, decimal salary, DateTime joinDate)
            : base(name, dob, salary)
        {
            JoinDate = joinDate;
        }

        // Method to calculate years of experience.
        public int GetYearsOfExperience()
        {
            return DateTime.Now.Year - JoinDate.Year;
        }

        // Polymorphism (Method Overriding): Implements the method from IInstructorService with custom behavior.
        public decimal CalculateBonusSalary()
        {
            return Salary + (1000 * GetYearsOfExperience()); // Bonus per year
        }

        // Polymorphism (Method Overriding): Overrides DisplayInfo() from the Person class.
        public override void DisplayInfo()
        {
            Console.WriteLine($"Instructor: {Name}, Age: {CalculateAge()}, Salary: {CalculateBonusSalary()}");
        }
    }
}
