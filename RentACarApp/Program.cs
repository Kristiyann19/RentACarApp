using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RentACarApp.Contracts;
using RentACarApp.Data;
using RentACarApp.Data.Entities;
using RentACarApp.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RentACarAppDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequiredLength = 6;
})
    .AddEntityFrameworkStores<RentACarAppDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/User/Login";
});


builder.Services.AddAuthentication()
    .AddFacebook(options =>
    {
        //TODO: Hide them somewhere. They should not be here.
        options.AppId = "497465629070832";
        options.AppSecret = "c98187fb17eb7e64ef80cac08cce3b28";
    });

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddTransient<IAgentService, AgentService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
