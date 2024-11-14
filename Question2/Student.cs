using System.Data.Common;

namespace Question2;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class StudentPool
{
    private List<Student> _students = new()
    {
        new Student { Id = 1, Name = "John" },
        new Student { Id = 2, Name = "Jane" },
        new Student { Id = 3, Name = "Jack" },
        new Student { Id = 4, Name = "Jill" },
        new Student { Id = 5, Name = "Joe" }
    };

    public List<Student> GetStudents(int count = 5)
    {
        if (_students.Count < count)
        {
            _students = new List<Student>
            {
                new Student { Id = 1, Name = "John" },
                new Student { Id = 2, Name = "Jane" },
                new Student { Id = 3, Name = "Jack" },
                new Student { Id = 4, Name = "Jill" },
                new Student { Id = 5, Name = "Joe" }
            };
        }
        
        return _students;
    }
}