namespace ASP_CORE_BASIC_NET_6_API.Models.Domain
{
    public class Asset
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public string? AssetName { get; set; }
        public double? AssetQuantity { get; set; }
    }
}
