using AutoMapper;
using TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF;
using TeknoLabs.Crm.Application.Services.ClientService;
using TeknoLabs.Crm.Domain;
using TeknoLabs.Crm.Domain.ClientEntities;
using TeknoLabs.Crm.Domain.Repositories.UCAFRepositories;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.Persistance.Services.ClientService
{
    public sealed class UCAFService : IUCAFService
    {
        private readonly IUCAFCommandRepository _commandRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private ClientDbContext _context;


        public UCAFService(IUCAFCommandRepository commandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateUcafAsync(CreateUCAFRequest request)
        {
            _context = (ClientDbContext)_contextService.CreateDbContextInstance(request.ClientId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);
            uniformChartOfAccount.Id = Guid.NewGuid().ToString();
            await _commandRepository.AddAsync(uniformChartOfAccount);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
