// namespace RefactoringLab;

// public class Notification
// {
//     public virtual void Send(string to, string message) =>
//         Console.WriteLine($"notify {to}: {message}");
// }

// public class EmailNotification : Notification
// {
//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[email] {to}: {message}");
// }

// public class SmsNotification : Notification
// {
//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[sms] {to}: {message}");
// }

// public class UrgentEmailNotification : EmailNotification
// {
//     public override void Send(string to, string message) =>
//         base.Send(to, $"[URGENT] {message}");
// }

// public class UrgentSmsNotification : SmsNotification
// {
//     public override void Send(string to, string message) =>
//         base.Send(to, $"[URGENT] {message}");
// }

// public class UrgentScheduledEmailNotification : UrgentEmailNotification
// {
//     public DateTime SendAt { get; set; }

//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[email scheduled {SendAt:g}] {to}: [URGENT] {message}");
// }

// public class UrgentScheduledSmsNotification : UrgentSmsNotification
// {
//     public DateTime SendAt { get; set; }

//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
// }

//=================================================================================================



using System.Reflection.Metadata.Ecma335;

public interface INotificationScheduler
{
    void Schedule(string sendAction);
}

public class ImmediateScheduler : INotificationScheduler
{
    public void Schedule(string sendAction)
    {
        Console.WriteLine($"[immedite] action {sendAction}");
    }
}


public class ScheduledScheduler : INotificationScheduler
{
    private readonly DateTime _sendAt;

    public ScheduledScheduler(DateTime sendAt)
    {
        _sendAt = sendAt;
    }

    public void Schedule(string sendAction)
    {
        Console.WriteLine($"Scheduled for {_sendAt:g}");
        Console.WriteLine($"{sendAction}");

        
    }
}


public interface INotificationChannel
{
    string Send(string to, string message);
}

public class EmailChannel : INotificationChannel
{
    public string Send(string to, string message){
        return $"[email] {to}: {message}";

    }
}

public class SmsChannel : INotificationChannel
{
    public string Send(string to, string message) =>
         $"[sms] {to}: {message}";
}

public interface IFormatter
{
    string Format(string message);
}

public class NormalMessageFormatter : IFormatter
{
    public string Format(string message) => message;
}

public class UrgentMessageFormatter : IFormatter
{
    public string Format(string message) =>
        $"[URGENT] {message}";
}



public class Notification
{
     public readonly INotificationChannel _channel;
     public readonly IFormatter _formatter;
     public readonly INotificationScheduler _scheduler;

    public Notification(INotificationChannel channel, IFormatter formatter, INotificationScheduler scheduler)
    {
        _channel = channel;
        _formatter = formatter;
        _scheduler = scheduler;
    }



   public void Send(string to, string message)
    {
        string formattedMessage = _formatter.Format(message);
        string notificationMessage = _channel.Send(to, formattedMessage);

        _scheduler.Schedule(notificationMessage);
    }
}