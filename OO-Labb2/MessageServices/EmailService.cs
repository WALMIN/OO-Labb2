namespace OO_Labb2
{
    public class EmailService : IMessageService
    {
        private IConsoleLogger _consoleLogger;
        public EmailService(IConsoleLogger consoleLogger)
        {
            this._consoleLogger = consoleLogger;
        }
        public void Send(Order order, string subject, string message)
        {
            // Some sending logic we don't care about
            _consoleLogger.Log($"Email sent to {order.Recipient} about order {order.ID}");
        }
    }
}
