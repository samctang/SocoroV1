namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationBookingCacheKeys
    {
        public static string ListKey => "OperationBookingList";

        public static string GetKey(int operationBookingId) => $"OperationBookingId-{operationBookingId}";
    }
}
