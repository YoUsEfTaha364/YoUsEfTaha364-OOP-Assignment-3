using RefactoringLab.Part02.Enrollment;
using RefactoringLab.Part02.Reports;

Console.WriteLine("=== Reports ===");


var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
Directory.CreateDirectory(outDir);

  ReportExporter csv=  new CsvReportExporter();
  csv.Export(Path.Combine(outDir, "report.csv"));

 ReportExporter json=new JsonReportExporter();
 json.Export(Path.Combine(outDir, "report.json"));

 ReportExporter text=new TextReportExporter();
 text.Export(Path.Combine(outDir, "report.txt"));
 
Console.WriteLine($"Wrote reports to {outDir}");
Console.WriteLine();





Console.WriteLine("=== Enrollment ===");
var studentId = "S100";
var courseId = "CS201";
var amount = 1500m;


var facade = new EnrollmentFacade(
    new PaymentGateway(),
    new SeatInventory(),
    new InvoiceGenerator(),
    new EmailService()
);

 var enrollment=new Enrollment(facade);

 enrollment.Enroll(studentId,courseId,amount);

