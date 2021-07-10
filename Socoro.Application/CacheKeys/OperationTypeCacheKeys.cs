namespace Socoro.Application.CacheKeys
{
    public static class OperationTypeCacheKeys
    {
        public static string ListKey => "OperationTypeList";

        public static string SelectListKey => "OperationTypeSelectList";

        public static string GetKey(int operationTypeId) => $"OperationType-{operationTypeId}";

        public static string GetDetailsKey(int operationTypeId) => $"OperationTypeDetails-{operationTypeId}";
    }
}