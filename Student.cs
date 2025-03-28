using System;
using System.Collections.Generic;
using UniversityManagementSystem;

public class Student : Person, IStudentService
{
    // Encapsulation: The 'courses' field is private and stores the list of courses and the corresponding grades.
    // Access to it is controlled through methods like EnrollCourse and CalculateGPA.
    private Dictionary<Course, char> courses = new Dictionary<Course, char>();

    // Constructor: The constructor initializes the 'Student' with a name and date of birth, calling the base class constructor.
    // In this case, the 'Salary' is set to 0 as it’s not applicable to a student.
    public Student(string name, DateTime dob) : base(name, dob, 0) { }

    // Encapsulation: This method allows the student to enroll in a course, updating the 'courses' dictionary.
    // The student's grade is initially set to 'N' (Not Graded), and the course is added to the course list of the course.
    public void EnrollCourse(Course course)
    {
        courses[course] = 'N'; // 'N' means Not Graded
        course.AddStudent(this); // Adds the student to the course
    }

    // Abstraction: The GPA calculation is abstracted into this method. It hides the internal details of GPA calculation 
    // from the user, providing a clean API for the GPA calculation. The method uses the grade points dictionary 
    // to convert grades to numerical values and compute the GPA.
    public double CalculateGPA()
    {
        if (courses.Count == 0) return 0.0;

        // This dictionary maps grades to grade points.
        Dictionary<char, double> gradePoints = new Dictionary<char, double>
        {
            {'A', 4.0}, {'B', 3.0}, {'C', 2.0}, {'D', 1.0}, {'F', 0.0}
        };

        double totalPoints = 0;
        int totalCourses = 0;

        // Loops through the courses and sums up the grade points based on the grades.
        foreach (var grade in courses.Values)
        {
            if (gradePoints.ContainsKey(grade))
            {
                totalPoints += gradePoints[grade]; // Adds the grade points for the course
                totalCourses++; // Counts the number of courses taken
            }
        }

        // Returns the GPA calculated based on grade points.
        return totalCourses == 0 ? 0 : totalPoints / totalCourses;
    }

    // Polymorphism: The DisplayInfo method is overridden to provide specific details of the Student class.
    // This is a virtual method in the base class (Person), but it is overridden here to display the student's name,
    // age, and GPA. The implementation in this class is specific to how student information should be displayed.
    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {CalculateAge()}, GPA: {CalculateGPA()}");
    }
}
