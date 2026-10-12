 namespace RefactoringLab;

// public class OrderProcessor
// {
//     public void Process(int orderId, string customerEmail)
//     {
//         var repo = new SqlOrderRepository();
//         var email = new SmtpEmailSender();

//         repo.Save(orderId, DateTime.Now);
//         email.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
//     }
// }

// public class SqlOrderRepository
// {
//     public void Save(int orderId, DateTime processedAt) =>
//         Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
// }

// public class SmtpEmailSender
// {
//     public void Send(string to, string body) =>
//         Console.WriteLine($"[SMTP] to={to} body={body}");
// }


//==================================================================================================



using Microsoft.VisualBasic;

public class OrderProcessor
{
    private readonly IOrderRepository _repo;
    private readonly IEmailSender _email;

    public OrderProcessor(IOrderRepository repo,IEmailSender email)
    {
        _repo=repo;
        _email=email;
    }
    public void Process(int orderId, string customerEmail)
    {
        

        _repo.Save(orderId, DateTime.Now);
        _email.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}
public interface IEmailSender
{
    void Send(string to , string body);
    
}
public interface IOrderRepository
{
     public void Save(int orderId, DateTime processedAt);
    
}



 public class SmtpEmailSender : IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}


public class SqlOrderRepository : IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}
