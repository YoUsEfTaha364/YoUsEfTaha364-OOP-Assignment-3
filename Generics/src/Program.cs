
using System.Net;
using src;



Store<Student> studentStore = new();
Store<Course> courseStore = new();


studentStore.Add(1, new Student { Id = 1, Name = "Ali" });
studentStore.Add(2, new Student { Id = 2, Name = "Omar" });
studentStore.Add(3, new Student { Id = 3, Name = "Ahmed" });
studentStore.Add(4, new Student { Id = 4, Name = "Mona" });
studentStore.Add(5, new Student { Id = 5, Name = "Sara" });


courseStore.Add(1, new Course { Id = 1, Title = "C#", Price = 500 });
courseStore.Add(2, new Course { Id = 2, Title = "Laravel", Price = 400 });
courseStore.Add(3, new Course { Id = 3, Title = "SQL", Price = 300 });


Student? student = studentStore.GetById(3);
Course? course2 = courseStore.GetById(2);

Console.WriteLine($"Student: {student?.Name ?? "Not found"}");
Console.WriteLine($"Course: {course2?.Title ?? "Not found"}");
//======================================================================================================

try
{
    studentStore.Add(1, new Student { Id = 6, Name = "Sara" });
}
catch (Exception e)
{
    Console.WriteLine(e.Message); // An item with the same key has already been added. Key: 1
}

//======================================================================================================


List<Course> courses =
[
    new Course { Id = 1, Title = "C#", Price = 500 },
    new Course { Id = 2, Title = "Laravel", Price = 400 },
    new Course { Id = 3, Title = "SQL", Price = 300 }
];

Console.WriteLine("\n--- Page 2: Courses ---");


foreach (var course1 in courses.Page(2, 2))
{  
    Console.WriteLine($"{course1.Id} - {course1.Title}");
    
}



//======================================================================================================





//   var str=new Store<string>(); // string does not have property Id