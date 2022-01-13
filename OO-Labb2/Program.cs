using OO_Labb2;

OrderService orderService = new OrderService(new ConsoleLogger(), new EmailService(new ConsoleLogger()));

orderService.Process(new Order
{
    Recipient = "example@example.com",
    ID = 12321,
    Priority = Priority.High,
    StreetAdress = "Some adress"
});

OrderService anotherOrderService = new OrderService(new ConsoleLogger(), new SMSService(new ConsoleLogger()));

anotherOrderService.Process(new Order
{
    Recipient = "+12345678901",
    ID = 98765,
    Priority = Priority.Low,
    StreetAdress = "Another adress"
});