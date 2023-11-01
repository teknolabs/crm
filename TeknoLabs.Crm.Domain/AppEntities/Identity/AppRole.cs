using Microsoft.AspNetCore.Identity;

namespace TeknoLabs.Crm.Domain.AppEntities.Identity
{
    public sealed class AppRole : IdentityRole<string>
    {
        public string Code { get; set; }
    }
}
