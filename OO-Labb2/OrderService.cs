namespace OO_Labb2
{
    public class OrderService
    {
        private IConsoleLogger _consoleLogger;
        private IMessageService _messageService;
        public OrderService(IConsoleLogger consoleLogger, IMessageService messageService)
        {
            this._consoleLogger = consoleLogger;
            this._messageService = messageService;
        }

        public void Process(Order order)
        {
            int priority = ProcessPriority(order.Priority);

            _consoleLogger.Log($"Started processing order {order.ID}");
            _messageService.Send(order, "Your order has been shipped", $"Your order with ID {order.ID} is expected to arrive within {priority} days.");
            _consoleLogger.Log($"Finished processing order with order {order.ID}");
            _consoleLogger.Log("");
        }

        public int ProcessPriority(Priority priority)
        {
            // Some priority logic we don't care about
            return Convert.ToInt32(priority);
        }

    }

}