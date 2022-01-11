namespace OO_Labb2
{
    public class OrderService
    {
        private IMessageService _messageService;
        public OrderService(IMessageService messageService)
        {
            this._messageService = messageService;
        }
        public void Process(Order order)
        {
            this._messageService.Process(order);

        }

    }

}