using System;
using AutoMapper;
using TeknoLabs.Crm.Application.Features.App.Client.Commands.CreateClient;
using TeknoLabs.Crm.Domain.AppEntities;

namespace TeknoLabs.Crm.Persistance.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateClientRequest, Client>().ReverseMap();
		}
	}
}

