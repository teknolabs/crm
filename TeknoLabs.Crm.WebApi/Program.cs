using Microsoft.AspNetCore.Identity;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using TeknoLabs.Crm.Presentation;
using TeknoLabs.Crm.WebApi.Configurations;
using TeknoLabs.Crm.WebApi.Middleware;

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

app.UseExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if (!userManager.Users.Any())
    {
        var result = await userManager.CreateAsync(new AppUser
        {
            UserName = "fatihcelen",
            Email = "fatihcelen@gmail.com",
            Id = Guid.NewGuid().ToString(),
            NameLastName = "Fatih ÇELEN"
        }, "Pass!123456");

        if (!result.Succeeded) throw new Exception(result.Errors.ToString());
    }
}

app.Run();