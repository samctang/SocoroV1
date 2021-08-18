namespace Socoro.Infrastructure.CacheKeys
{
    public static class OperationInsuranceCacheKeys
    {
        public static string ListKey => "OperationInsuranceList";
        public static string GetKey(int operationInsuranceId) => $"OperationInsuranceId-{operationInsuranceId}";
    }
}