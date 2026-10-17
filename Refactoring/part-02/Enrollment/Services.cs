namespace RefactoringLab.Part02.Enrollment;

public class PaymentGateway
{
    public void Charge(string studentId, decimal amount) =>
        Console.WriteLine($"charge {studentId}: {amount}");
}

public class SeatInventory
{
    public void Reserve(string courseId, string studentId) =>
        Console.WriteLine($"reserve seat {courseId} for {studentId}");
}

public class InvoiceGenerator
{
    public string Create(string studentId, decimal amount)
    {
        var invoiceId = $"INV-{studentId}-{amount}";
        Console.WriteLine($"invoice {invoiceId}");
        return invoiceId;
    }
}

public class EmailService
{
    public void Send(string studentId, string subject, string body) =>
        Console.WriteLine($"email {studentId}: {subject} / {body}");
}

public class EnrollmentService
{
    private readonly PaymentGateway _paymentGateway;
    private readonly SeatInventory _seatInventory;
    private readonly InvoiceGenerator _invoiceGenerator;
    private readonly EmailService _emailService;
    public EnrollmentService(PaymentGateway paymentGateway, SeatInventory seatInventory, InvoiceGenerator invoiceGenerator, EmailService emailService)
    {
        _paymentGateway = paymentGateway;
        _seatInventory = seatInventory;
        _invoiceGenerator = invoiceGenerator;
        _emailService = emailService;
    }
    public void Enroll(string studentId, string courseId, decimal amount)
    {
        _paymentGateway.Charge(studentId, amount);
        _seatInventory.Reserve(courseId, studentId);
        var invoiceId = _invoiceGenerator.Create(studentId, amount);
        _emailService.Send(studentId, "Enrollment Confirmation", $"You have been enrolled in {courseId}. Invoice: {invoiceId}");
    }
}