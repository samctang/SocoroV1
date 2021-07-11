namespace Socoro.Infrastructure.CacheKeys
{
    public static class CustomerCacheKeys
    {
        public static string ListKey => "CustomerList";

        public static string SelectListKey => "CustomerSelectList";

        public static string GetKey(int customerId) => $"Customer-{customerId}";

        public static string GetDetailsKey(int customerId) => $"CustomerDetails-{customerId}";
    }
}