using System;
using UniversityManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        // Create students
        Student student1 = new Student("Alice", new DateTime(2002, 5, 20));
        Student student2 = new Student("Bob", new DateTime(2001, 8, 15));

        // Create instructor
        Instructor instructor1 = new Instructor("Dr. Smith", new DateTime(1980, 3, 12), 50000, new DateTime(2010, 9, 1));

        // Create courses
        Course math = new Course("Mathematics");
        Course cs = new Course("Computer Science");

        // Enroll students in courses
        student1.EnrollCourse(math);
        student1.EnrollCourse(cs);
        student2.EnrollCourse(cs);

        // Create department
        Department csDepartment = new Department("Computer Science", 1000000, new DateTime(2024, 1, 1), new DateTime(2025, 12, 31));
        csDepartment.AssignHead(instructor1);
        csDepartment.AddCourse(cs);

        // Display information
        student1.DisplayInfo();
        student2.DisplayInfo();
        instructor1.DisplayInfo();
    }
}

