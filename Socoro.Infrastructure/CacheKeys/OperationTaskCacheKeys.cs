namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationTaskCacheKeys
    {
        public static string ListKey => "OperationTaskList";
        public static string GetKey(int operationTaskId) => $"OperationTaskId-{operationTaskId}";
    }
}