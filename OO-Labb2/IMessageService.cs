namespace OO_Labb2
{
    public interface IMessageService
    {
        void Process(Order order);
        void Log(string message);
        int ProcessPriority(Priority priority);
        void SendOrder(Order order, string subject, string message);

    }
}
