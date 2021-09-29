using Microsoft.AspNetCore.Identity;

namespace DAL.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
