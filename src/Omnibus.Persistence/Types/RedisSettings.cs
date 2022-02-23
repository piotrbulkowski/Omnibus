namespace Omnibus.Persistence.Types
{
    internal class RedisSettings
    {
        public string ConnectionString { get; set; } = "localhost";
        public int? DefaultDatabase { get; set; }
        public int KeepAlive { get; set; } = -1;
        public int ConnectRetry { get; set; } = 3;
        public int ConnectTimeout { get; set; } = 5000;
    }
}
