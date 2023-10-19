using MediatR;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using TeknoLabs.Crm.Persistance.Context;
using TeknoLabs.Crm.Presentation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(TeknoLabs.Crm.Application.AssemblyReferance).Assembly);
builder.Services.AddAutoMapper(typeof(TeknoLabs.Crm.Persistance.AssemblyReferance).Assembly);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TeknoLabsCrmDbContext")));
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddControllers().AddApplicationPart(typeof(AssemblyReferance).Assembly);
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