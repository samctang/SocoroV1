namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationContainerCacheKeys
    {
        public static string ListKey => "OperationContainerList";

        public static string GetKey(int operationContainerId) => $"OperationContainerId-{operationContainerId}";
    }
}
