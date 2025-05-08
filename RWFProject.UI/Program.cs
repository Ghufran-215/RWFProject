using DapperMvcDemo.Data.Repository;
using RWFProject.Data.DataAccess;
using RWFProject.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Register custom services
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IRegistrationRepository, RegistrationRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Default route points to RegistrationController if that's the main controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Registration}/{action=DisplayAll}/{id?}");

app.Run();
