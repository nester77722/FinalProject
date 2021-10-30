using System.Collections.Generic;

namespace PL.Models
{
    public class UserModelWithTokens
    {
        public string AccessToken { get; set; } 
        public string RefreshToken { get; set; } 
        public string Id { get; set; } 
        public string UserName { get; set; } 
        public IEnumerable<string> Roles { get; set; } 
    }
}