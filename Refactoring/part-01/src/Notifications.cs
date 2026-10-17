namespace RefactoringLab;

public interface INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"notify {to}: {message}");
}

public class EmailNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}

public class UrgentEmailNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine(to, $"[URGENT] {message}");
}

public class UrgentSmsNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine(to, $"[URGENT] {message}");
}

public class UrgentScheduledEmailNotification : INotification
{
    public DateTime SendAt { get; set; }

    public void Send(string to, string message) =>
        Console.WriteLine($"[email scheduled {SendAt:g}] {to}: [URGENT] {message}");
}

public class UrgentScheduledSmsNotification : INotification
{
    public DateTime SendAt { get; set; }

    public void Send(string to, string message) =>
        Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
}
public class NewNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[new] {to}: {message}");
}
public class NotificationService
{
    private readonly INotification _notification;
    public NotificationService(INotification notification)
    {
        _notification = notification;
    }
    public void Send(string to, string message) =>
        _notification.Send(to, message);
}
