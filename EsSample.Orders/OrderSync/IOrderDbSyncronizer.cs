namespace EsSample.Orders.OrderSync
{
    public interface IOrderDbSyncronizer
    {
        void ProcessExistingEvents();
        void SubscribeToFutureEvents();
    }
}