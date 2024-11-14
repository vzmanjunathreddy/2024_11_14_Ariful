using Question4.Models;

namespace Question4.Services;

public class StudentService
{
    private readonly List<Student> _students = new List<Student>
    {
        new Student
        {
            Id = 1, Name = "Alex", Age = 25, GPA = 3.5,
            Courses = new List<Course> { new Course { Id = 1, Name = "Math", Credits = 3 } }
        },
        new Student
        {
            Id = 2, Name = "Jack", Age = 25, GPA = 3.8, Courses = { new Course { Id = 2, Name = "Math", Credits = 3 } }
        },
        new Student
        {
            Id = 3, Name = "John", Age = 25, GPA = 3.9, Courses = { new Course { Id = 3, Name = "Math", Credits = 3 } }
        }
    };

    public Student? GetStudentWithHighestGPA()
    {
        if (_students.Count == 0) return null;

        var student = _students.OrderByDescending(o => o.GPA).FirstOrDefault();
        return student;
    }

    public List<Student> GetAgeSortedStudents()
    {
        return _students.OrderBy(o => o.Age).ToList();
    }

    public double GetAverageGPA()
    {
        return _students.Average(a => a.GPA);
    }

    public List<Student> GetFilteredStudents(double minGPA = 3.0)
    {
        return _students.Where(a => a.GPA >= minGPA).ToList();
    }
}