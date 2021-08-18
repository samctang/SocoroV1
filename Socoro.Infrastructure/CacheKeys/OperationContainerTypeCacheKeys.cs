namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationContainerTypeCacheKeys
    {
        public static string ListKey => "OperationContainerTypeList";
        public static string GetKey(int operationContainerTypeId) => $"OperationContainerTypeId-{operationContainerTypeId}";
    }
}