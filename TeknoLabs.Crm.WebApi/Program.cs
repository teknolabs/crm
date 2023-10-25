using MediatR;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Application.Services.ClientService;
using TeknoLabs.Crm.Domain;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using TeknoLabs.Crm.Domain.Repositories.UCAFRepositories;
using TeknoLabs.Crm.Persistance;
using TeknoLabs.Crm.Persistance.Context;
using TeknoLabs.Crm.Persistance.Repositories.UCAFRepositories;
using TeknoLabs.Crm.Persistance.Services.App;
using TeknoLabs.Crm.Persistance.Services.ClientService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
builder.Services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
builder.Services.AddScoped<IUCAFService, UCAFService>();
builder.Services.AddScoped<IContextService, ContextService>();

// Add services to the container. 
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(TeknoLabs.Crm.Application.AssemblyReferance).Assembly));
builder.Services.AddAutoMapper(typeof(TeknoLabs.Crm.Persistance.AssemblyReferance).Assembly);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TeknoLabsCrmDbContext")));
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddControllers().AddApplicationPart(typeof(TeknoLabs.Crm.Presentation.AssemblyReferance).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();