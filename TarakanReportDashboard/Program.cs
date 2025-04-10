using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
//using Syncfusion.Blazor;
using TarakanReportDashboard;
using TarakanReportDashboard.Components;
using TarakanReportDashboard.Services;
using BitzArt.Blazor.Auth.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddBlazorBootstrap();
builder.AddBlazorAuth<TarakanAuthenticationService>();
builder.Services.AddScoped<JwtService>();


var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");
builder.Services.AddDbContextFactory<TarakanReportDashboard.Models.TarakanContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddCascadingAuthenticationState();

builder.Services.AddAuthentication(Constants.AuthScheme)
    .AddCookie(Constants.AuthScheme, options =>
    {
        options.Cookie.Name = Constants.AuthCookie;
        options.LoginPath = "/auth/login";
        options.AccessDeniedPath = "/auth/access-denied";
        options.LogoutPath = "/auth/logout";

        options.Cookie.HttpOnly = true;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        options.Cookie.SameSite = SameSiteMode.Strict;

        options.ExpireTimeSpan = TimeSpan.FromDays(1);
        options.SlidingExpiration = true;
    });

//builder.Services.AddSyncfusionBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTY2OEAzMjM4MkUzMjJFMzNlQy94VWxTUmtzakV6eVJ1YUcxa2NKZHIyN2VQckRDNUU3TEN0SHVHNlVrPQ==");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication()
    .UseAuthorization();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapAuthEndpoints();

var components = app.MapRazorComponents<TarakanReportDashboard.Components.App>()
    .AddInteractiveServerRenderMode();

components.Add(e => {
    if (e is RouteEndpointBuilder rb)
    {
        if (rb.RoutePattern!.RawText!.Contains("_blazor"))
        {
            rb.Metadata.Add(new AllowAnonymousAttribute());
        }
    }
});

app.Run();
