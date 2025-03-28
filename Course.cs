using System;
using System.Collections.Generic;

// Encapsulation: The Course class restricts direct access to its student list.
public class Course : ICourseService
{
    // Encapsulation: Public property to store the course name, allowing controlled access.
    public string CourseName { get; set; }

    // Encapsulation: Private list to store enrolled students, preventing direct modification from outside.
    private List<Student> enrolledStudents = new List<Student>();

    // Constructor to initialize a course with a name.
    public Course(string name)
    {
        CourseName = name;
    }

    // Abstraction: Implements the AddStudent method from ICourseService without exposing details of list operations.
    public void AddStudent(Student student)
    {
        enrolledStudents.Add(student); // Adds a student to the course.
    }
}
