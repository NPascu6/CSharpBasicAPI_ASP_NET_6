﻿using ASP_CORE_BASIC_NET_6_API.Models.Domain;

namespace ASP_CORE_BASIC_NET_6_API.Models.DTOs
{
    public class UserDetailsDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? BirthDate { get; set; }
        public UserRole? UserRole { get; set; }
        public Wallet? Wallet { get; set; }
    }
}
