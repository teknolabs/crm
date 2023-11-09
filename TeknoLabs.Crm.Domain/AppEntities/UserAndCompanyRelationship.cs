using TeknoLabs.Crm.Domain.Abstract;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeknoLabs.Crm.Domain.AppEntities;

public class UserAndCompanyRelationship: Entity
{
    public UserAndCompanyRelationship()
    {

    }

    public UserAndCompanyRelationship(string id, string appUserId, string clientId)
    {
        AppUserId = appUserId;
        ClientId = clientId;
    }

    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }

    [ForeignKey("Client")]
    public string ClientId { get; set; }
    public Client Client { get; set; }
}
