using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using TeknoLabs.Crm.Domain.Abstract;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TeknoLabs.Crm.Domain.AppEntities;

public class MainRole : Entity
{
    public MainRole()
    {

    }

    public MainRole(string id, string title, bool isRoleCreatedByAdmin = false, string clientId = null) 
    {
        Title = title;
        IsRoleCreatedByAdmin = isRoleCreatedByAdmin;
        ClientId = clientId;
    }

    public string Title { get; set; }
    public bool IsRoleCreatedByAdmin { get; set; }

    [ForeignKey("Client")]
    public string ClientId { get; set; }
    public Client? Client { get; set; }
}