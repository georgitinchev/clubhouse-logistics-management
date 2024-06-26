using Microsoft.AspNetCore.Authentication.Cookies;
using MediaBazaar.Classes;
using BusinessLogicLayer;
using MediaBazaar;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<EmployeeManager>();
builder.Services.AddScoped<EmergencyContactManager>();
builder.Services.AddScoped<EmployeeWorksheetManager>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = "/Login";
	});

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/");
    options.Conventions.AllowAnonymousToPage("/Login");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.Run();