using ASP_CORE_BASIC_NET_6_API.Models.Domain;

namespace ASP_CORE_BASIC_NET_6_API.Models.DTOs
{
    public class WalletDTO
    {
        public int WalletId { get; set; }
        public string? WalletName { get; set; }
        public IEnumerable<AssetDTO>? Assets { get; set; }
    }
}
