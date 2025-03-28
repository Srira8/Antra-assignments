using System;
using System.Collections.Generic;
using UniversityManagementSystem;

public class Department : IDepartmentService
{
    // Encapsulation: The properties are public, providing controlled access to department details.
    public string Name { get; set; }  // Department name
    public decimal Budget { get; set; }  // Budget allocated to the department
    public DateTime StartYear { get; set; }  // The year the department was established
    public DateTime EndYear { get; set; }  // The year the department ended (if applicable)

    // Encapsulation: The Head property has a private setter to restrict modifications outside the class.
    public Instructor Head { get; private set; }

    // Encapsulation: The list of courses is private to restrict direct access and modifications.
    private List<Course> courses = new List<Course>();

    // Constructor: Initializes the department with essential details.
    public Department(string name, decimal budget, DateTime startYear, DateTime endYear)
    {
        Name = name;
        Budget = budget;
        StartYear = startYear;
        EndYear = endYear;
    }

    // Encapsulation: This method allows assigning an instructor as the head of the department.
    // The private setter ensures that only this method can modify the Head property.
    public void AssignHead(Instructor instructor)
    {
        Head = instructor;
    }

    // Encapsulation: This method provides a controlled way to add courses to the department.
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
}
