using Microsoft.AspNetCore.Identity;

namespace PL.ViewModels.Authentication
{
    public class RefreshTokenViewModel
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
