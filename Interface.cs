using UniversityManagementSystem;

// Interface Segregation: Defines a contract for all person-related functionalities.
public interface IPersonService
{
    // Abstraction: Defines a method to calculate the age of a person.
    int CalculateAge();

    // Abstraction: Provides a method signature for calculating salary.
    decimal CalculateSalary();

    // Abstraction & Encapsulation: Defines a method to get a list of addresses without exposing direct data storage.
    List<string> GetAddresses();
}

// Interface Segregation: Specific interface for students extending the general person service.
public interface IStudentService : IPersonService
{
    // Abstraction: Provides a method to calculate GPA without revealing implementation details.
    double CalculateGPA();

    // Abstraction: Defines the method for enrolling in a course.
    void EnrollCourse(Course course);
}

// Interface Segregation: Specific interface for instructors extending the general person service.
public interface IInstructorService : IPersonService
{
    // Abstraction: Defines a method for calculating a bonus salary for instructors.
    decimal CalculateBonusSalary();
}

// Abstraction: Defines a contract for adding students to a course.
public interface ICourseService
{
    void AddStudent(Student student);
}

// Abstraction: Defines a contract for department-related functionalities.
public interface IDepartmentService
{
    void AssignHead(Instructor instructor);
}
