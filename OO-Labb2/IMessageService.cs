namespace OO_Labb2
{
    public interface IMessageService
    {
        void Send(Order order, string subject, string message);
    }
}
