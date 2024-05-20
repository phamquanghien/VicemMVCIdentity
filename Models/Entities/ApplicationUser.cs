using Microsoft.AspNetCore.Identity;

namespace VicemMVCIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}
