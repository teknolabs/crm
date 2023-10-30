using System;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Abstractions
{
	public interface IJwtProvider
	{
		Task<string> CreateTokenAsync(AppUser appUser, List<string> roles);
	}
}

