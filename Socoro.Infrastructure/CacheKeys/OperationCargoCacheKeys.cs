namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationCargoCacheKeys
    {
        public static string ListKey => "OperationCargoList";

        public static string GetKey(int operationCargoId) => $"OperationCargoId-{operationCargoId}";
    }
}
