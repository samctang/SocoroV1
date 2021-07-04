namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationCacheKeys
    {
        public static string ListKey => "OperationList";

        public static string SelectListKey => "OperationSelectList";

        public static string GetKey(int operationId) => $"Operation-{operationId}";

        public static string GetDetailsKey(int operationId) => $"OperationDetails-{operationId}";
    }
}