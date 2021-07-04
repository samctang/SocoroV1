namespace Socoro.Application.CacheKeys
{
    public static class OperationCacheKeys
    {
        public static string ListKey => "OperationList";

        public static string SelectListKey => "OperationSelectList";

        public static string GetKey(int OperationId) => $"Operation-{OperationId}";

        public static string GetDetailsKey(int OperationId) => $"OperationDetails-{OperationId}";
    }
}