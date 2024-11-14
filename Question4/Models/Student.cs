namespace Question4.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
}