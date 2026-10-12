using RefactoringLab;

var aramex = new ShippingCostCalculator( new
    AramexShippingCostStrategy());

var fedEx = new ShippingCostCalculator( new 
    FedExShippingCostStrategy());

Console.WriteLine($"Aramex 2kg → {aramex.Calculate(2m)}");
Console.WriteLine($"FedEx 2kg  → {fedEx.Calculate(2m)}");
Console.WriteLine();

 IOrderRepository  repo= new SqlOrderRepository();
 IEmailSender email = new SmtpEmailSender();

var processor = new OrderProcessor(repo, email);

processor.Process(1001, "customer@example.com");

Console.WriteLine();


  var notification=new Notification(new EmailChannel(),new NormalMessageFormatter(),new ScheduledScheduler(DateTime.Now));


  notification.Send("yousef@gmail.com","hello joe lets got tommorow");

