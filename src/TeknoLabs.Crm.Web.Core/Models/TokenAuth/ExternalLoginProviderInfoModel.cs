using Abp.AutoMapper;
using TeknoLabs.Crm.Authentication.External;

namespace TeknoLabs.Crm.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
