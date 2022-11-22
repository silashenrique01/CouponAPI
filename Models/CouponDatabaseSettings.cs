namespace CouponAPI.Models
{
    public class CouponDatabaseSettings : ICouponDatabaseSettings
    {
        public string CouponsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ICouponDatabaseSettings
    {
        string CouponsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
