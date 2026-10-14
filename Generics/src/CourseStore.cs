using System;

namespace src;

public class CourseStore
{
    private readonly List<Course> _courses = new();

    private IReadOnlyList<Course> _CoursesView;

    public CourseStore()
    {
        _CoursesView = _courses;
    }
    public void Add(Course Course)
    {
        _courses.Add(Course);
    }

    public Course? GetById(int id)
    {

        foreach (var Course in _courses)
        {
            if (Course.Id == id)
                return Course;
        }
        return null;
    }

    public IReadOnlyList<Course> GetAll()
    {
        return _CoursesView;
    }
    public void Remove(int id)
    {
        var Course = GetById(id);

        if (Course == null)
        {
            Console.WriteLine("Course not found");
            return;
        }
        _courses.Remove(Course);
        Console.WriteLine("Course removed successfully");
    }

}
