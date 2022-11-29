using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AppMVCBasica.Data;
var builder = WebApplication.CreateBuilder(args);

// Guardando a connection string do arquivo appSettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AplicationDbContext>();

// Adicionando o suporte ao acesso ao DB do Identity via EF
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));

// Adicionando a tela de erro de banco de dados (para desenvolvimento)
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Adicionando o Identity
//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>();

// Adicionando o MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura��o conforme os ambientes
if (app.Environment.IsDevelopment())
{
    //app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
