namespace RefactoringLab;

public class OrderProcessor
{
    private readonly ISqlOrderRepository _orderRepository;
    private readonly ISmtpEmailSender _emailSender;
    public OrderProcessor(ISqlOrderRepository orderRepository, ISmtpEmailSender emailSender)
    {
        _orderRepository = orderRepository;
        _emailSender = emailSender;
    }
    public void Process(int orderId, string customerEmail)
    {
        var dateTimeNow = DateTime.Now;
        _orderRepository.Save(orderId, dateTimeNow);
        _emailSender.Send(customerEmail, $"Order {orderId} confirmed at {dateTimeNow}");
    }
}
public interface ISqlOrderRepository
{
    public void Save(int orderId, DateTime processedAt);
}

public interface ISmtpEmailSender
{
    public void Send(string to, string body);
}


public class SqlOrderRepository : ISqlOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender : ISmtpEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}
