using System.Collections.Generic;

namespace TeknoLabs.Crm.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
