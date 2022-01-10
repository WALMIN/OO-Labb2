using OO_Labb2;

OrderService orderService = new OrderService();

orderService.Process(new Order
{
    Recipient = "example@example.com",
    ID = 12321,
    Priority = Priority.High,
    Service = Service.Email,
    StreetAdress = "Some adress"
});

orderService.Process(new Order
{
    Recipient = "+12345678901",
    ID = 98765,
    Priority = Priority.Low,
    Service = Service.SMS,
    StreetAdress = "Another adress"
});