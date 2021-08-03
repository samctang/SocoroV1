namespace Socoro.Infrastructure.CacheKeys
{
    public static class CustomerCacheKeys
    {
        public static string ListKey => "CustomerList";

        public static string CompanyListKey => "CompanyList";

        public static string GetKey(int customerId) => $"CustomerId-{customerId}";
    }
}