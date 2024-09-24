using Microsoft.EntityFrameworkCore;
using JogosPS2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string conexao = builder.Configuration.GetConnectionString("JogosPS2Conexao");
var versao = ServerVersion.AutoDetect(conexao);
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(conexao, versao)
);

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
