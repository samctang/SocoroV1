namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationProcessTypeCacheKeys
    {
        public static string SelectListKey => "OperationProcessTypeSelectList";
        public static string GetKey(int operationTypeId) => $"OperationType-{operationTypeId}";
    }
}