using TeknoLabs.Crm.Presentation;
using TeknoLabs.Crm.WebApi.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);
//builder.Services.AddAuthorization();
//builder.Services.AddAuthentication();
//builder.Services.AddControllers().AddApplicationPart(typeof(AssemblyReferance).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();