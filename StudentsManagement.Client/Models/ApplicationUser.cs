﻿
using Microsoft.AspNetCore.Identity;
using StudentsManagement.Client.Models;

namespace StudentsManagement.Client.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Photo { get; set; }
        public int GenderId { get; set; }
        public SystemCodeDetail Gender { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public bool IsActive { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime? DeactivatedOn { get; set; }
    }
}
