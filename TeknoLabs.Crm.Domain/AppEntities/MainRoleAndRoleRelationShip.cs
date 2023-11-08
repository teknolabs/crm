using System;
using System.ComponentModel.DataAnnotations.Schema;
using TeknoLabs.Crm.Domain.Abstract;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Domain.AppEntities;

public sealed class MainRoleAndRoleRelationShip : Entity
{
    public MainRoleAndRoleRelationShip()
    {

    }
    public MainRoleAndRoleRelationShip(string id, string roleId, string mainRoleId)  
    {
        RoleId = roleId;
        MainRoleId = mainRoleId;
    }
    [ForeignKey("AppRole")]
    public string RoleId { get; set; }
    public AppRole AppRole { get; set; }

    [ForeignKey("MainRole")]
    public string MainRoleId { get; set; }
    public MainRole MainRole { get; set; }
}

