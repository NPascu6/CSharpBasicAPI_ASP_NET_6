namespace ASP_CORE_BASIC_NET_6_API.Models.Domain
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public Guid? UserDetailsId { get; set; }
        public string? WalletName { get; set; }
        public IEnumerable<Asset>? Assets { get; set; }
    }
}
