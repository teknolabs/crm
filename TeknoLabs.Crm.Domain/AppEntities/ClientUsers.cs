using System.ComponentModel.DataAnnotations.Schema;
using TeknoLabs.Crm.Domain.Abstract;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Domain.AppEntities
{
    public class ClientUsers : Entity
    {
        [ForeignKey("Client")]
        public string ClienId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("AppUser")]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
