namespace RefactoringLab.Part03.Students;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

public static class StudentCatalog
{
    // public static List<Student> GetAllStudents()
    // {
    //     var students = new List<Student>();
    //     for (var i = 1; i <= 1_000_000; i++)
    //         students.Add(new Student { Id = i, Name = $"Student {i}" });
    //     return students;
    // }


        public static IEnumerable<Student> GetAllStudents()
    {
        var students = new List<Student>();
        for (var i = 1; i <= 1_000_000; i++){
        var student=new Student { Id = i, Name = $"Student {i}" };
            students.Add(student);
            yield return student;

        }

    
    }
}
