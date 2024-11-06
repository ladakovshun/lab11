using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebApplication111.Filters;
using WebApplication111.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ��������� ������ ��� ���������
builder.Services.AddSingleton<ILogService, LogService>();

// ��������� ������� �� ������
builder.Services.AddScoped<ActionLoggingFilter>();
builder.Services.AddScoped<UniqueUsersFilter>();

// ������ ������� �� MVC �� �������� �������
builder.Services.AddMvc(options =>
{
    options.Filters.AddService<ActionLoggingFilter>();
    options.Filters.AddService<UniqueUsersFilter>();
});

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
