using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using JogosPS2.Data;
using Playstation2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string conexao = builder.Configuration
.GetConnectionString("jogosps2Conexao");
var versao = ServerVersion.AutoDetect(conexao);
builder.Services.AddDbContext<AppDbContext>(
opt => opt.UseMySql(conexao, versao));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
