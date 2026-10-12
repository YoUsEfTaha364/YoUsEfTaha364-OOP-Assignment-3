using System;

namespace RefactoringLab.Part02.Enrollment;

public class Enrollment
{
     private readonly EnrollmentFacade _enrollment;

    public Enrollment(EnrollmentFacade enrollment)
    {
        _enrollment = enrollment;
    }

    public void Enroll(
        string studentId,
        string courseId,
        decimal amount)
    {
        _enrollment.Enroll(studentId,courseId,amount);
    }
}
