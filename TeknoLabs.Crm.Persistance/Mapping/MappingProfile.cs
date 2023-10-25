using System;
using AutoMapper;
using TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.CreateClient;
using TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF;
using TeknoLabs.Crm.Domain.AppEntities;
using TeknoLabs.Crm.Domain.ClientEntities;

namespace TeknoLabs.Crm.Persistance.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateClientRequest, Client>().ReverseMap();
			CreateMap<CreateUCAFRequest, UniformChartOfAccount>().ReverseMap();
		}
	}
}

