using Microsoft.AspNetCore.Identity;

namespace Fiorella.Models
{
    public class User:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
