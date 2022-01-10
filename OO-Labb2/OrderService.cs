namespace OO_Labb2
{
    public class OrderService
    {
        public void Process(Order order)
        {
            int priority = ProcessPriority(order.Priority);

            Log($"Started processing order {order.ID}");
            SendOrder(order, "Your order has been shipped", $"Your order with ID {order.ID} is expected to arrive within {priority}");
            Log($"Finished processing order with order {order.ID}");
        }

        private void Log(string message)
        {
            // Some logging logic
            Console.WriteLine(message);
        }

        private int ProcessPriority(Priority priority)
        {
            // Some priority logic we don't care about
            return Convert.ToInt32(priority);
        }

        private void SendOrder(Order order, string subject, string message)
        {
            // Some sending logic we don't care about
            Log($"{order.Service} sent to {order.Recipient} about order {order.ID}");
        }

    }
}
