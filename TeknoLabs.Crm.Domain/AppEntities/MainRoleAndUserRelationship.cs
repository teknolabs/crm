using TeknoLabs.Crm.Domain.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Domain.AppEntities;

public sealed class MainRoleAndUserRelationship : Entity
{
    public MainRoleAndUserRelationship()
    {

    }

    public MainRoleAndUserRelationship(string id, string userId, string mainRoleId, string clientId) 
    {
        UserId = userId;
        ClientId = clientId;
        MainRoleId = mainRoleId;
    }

    [ForeignKey("AppUser")]
    public string UserId { get; set; }
    public AppUser AppUser { get; set; }

    [ForeignKey("MainRole")]
    public string MainRoleId { get; set; }
    public MainRole MainRole { get; set; }

    [ForeignKey("Client")]
    public string ClientId { get; set; }
    public Client Client { get; set; }
}
