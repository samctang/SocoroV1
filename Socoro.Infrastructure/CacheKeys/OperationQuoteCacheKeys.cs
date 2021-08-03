namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationQuoteCacheKeys
    {
        public static string ListKey => "OperationQuoteList";

        public static string GetKey(int operationQuoteId) => $"OperationQuoteId-{operationQuoteId}";
    }
}
