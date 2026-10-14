using System;

namespace src;

public class StudentStore
{
private readonly List<Student> _students = new();

private IReadOnlyList<Student> _studentsView;

public StudentStore()
{
    _studentsView = _students;
}   public void Add(Student student)
    {
        _students.Add(student);
    }

    public Student? GetById(int id)
    {
        
        foreach(var student in _students)
        {
            if(student.Id==id)
            return student;
        }
        return null;
    }

    public IReadOnlyList<Student> GetAll()
    {
        return _studentsView;
    }
    public void Remove(int id)
    {
        var student=GetById(id);

        if (student == null)
        {
            Console.WriteLine("student not found");
            return;
        }
        _students.Remove(student);
         Console.WriteLine("student removed successfully");
    }

}
