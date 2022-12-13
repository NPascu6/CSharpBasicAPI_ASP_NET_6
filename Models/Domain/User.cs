namespace ASP_CORE_BASIC_NET_6_API.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
        public UserDetails? UserDetails { get; set; }
    }
}
