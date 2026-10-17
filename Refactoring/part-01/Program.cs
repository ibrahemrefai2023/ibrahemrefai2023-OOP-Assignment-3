using RefactoringLab;

var shipping = new ShippingCostCalculator();
var aramex = new AramexCalculator();
var fedex = new FedExCalculator();
var dhl = new DHLCalculator();
var newCalculator = new NewCalculator();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate(aramex, 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(fedex, 2)}");
Console.WriteLine($"DHL 2kg    → {shipping.Calculate(dhl, 2)}");
Console.WriteLine($"New 2kg    → {shipping.Calculate(newCalculator, 2)}");
Console.WriteLine(" ");

var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine(" ");


var urgentScheduledEmailNotification = new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) };
var notificationService = new NotificationService(urgentScheduledEmailNotification);
notificationService.Send("customer@example.com", "Your order ships tomorrow");
var urgentSmsNotification = new UrgentSmsNotification();
 notificationService = new NotificationService(urgentSmsNotification);
notificationService.Send("+201000000000", "OTP 4821");
var newNotification = new NewNotification();
 notificationService = new NotificationService(newNotification);
notificationService.Send("customer@example.com", "This is a new notification");

Console.ReadLine();
