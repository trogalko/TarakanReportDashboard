using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
//using Syncfusion.Blazor;
using TarakanReportDashboard;
using TarakanReportDashboard.Components;
using TarakanReportDashboard.Services;
using BitzArt.Blazor.Auth.Server;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Telerik.Reporting.Services;
using Telerik.Reporting.Cache.File;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Telerik.Blazor.Services;
using Telerik.ReportViewer.BlazorNative.Services;
using TarakanReportDashboard.Controllers;
using Microsoft.AspNetCore.Rewrite;

const string NewBlazorHubUrl = "/dashboardreport";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddBlazorBootstrap();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.AddBlazorAuth<TarakanAuthenticationService>();
builder.Services.AddScoped<JwtService>();

//Telerik Reporting
var reportsPath = Path.Combine(builder.Environment.ContentRootPath);

builder.Services.TryAddSingleton<IReportServiceConfiguration>(sp => new
    ReportServiceConfiguration
{
    // The default ReportingEngineConfiguration will be initialized from appsettings.json or appsettings.{EnvironmentName}.json:
    ReportingEngineConfiguration = sp.GetService<IConfiguration>(),

    // In case the ReportingEngineConfiguration needs to be loaded from a specific configuration file, use the approach below:
    //ReportingEngineConfiguration = ResolveSpecificReportingConfiguration(sp.GetService<IWebHostEnvironment>()),
    HostAppId = "TarakanReporting",
    Storage = new FileStorage(),
    ReportSourceResolver = new UriReportSourceResolver(System.IO.Path.Combine(reportsPath))
});

builder.Services.AddScoped(typeof(ITelerikReportingStringLocalizer), typeof(CustomStringLocalizer));
builder.Services.AddScoped(typeof(ITelerikStringLocalizer), typeof(TelerikCustomStringLocalizer));
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    // define the list of cultures your app will support
    var supportedCultures = new List<CultureInfo>()
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("id-ID")
                };

    options.DefaultRequestCulture = new RequestCulture("en-US");

    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
//End of Telerik Reporting

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

app.MapStaticAssets();

app.MapAuthEndpoints();

app.MapControllers();
app.MapDefaultControllerRoute();

var components = app.MapRazorComponents<TarakanReportDashboard.Components.App>()
    .AddInteractiveServerRenderMode()
    .RequireAuthorization();

components.Add(e => {
    if (e is RouteEndpointBuilder rb)
    {
        if (rb.RoutePattern!.RawText!.Contains("_blazor"))
        {
            rb.Metadata.Add(new AllowAnonymousAttribute());
        }
    }
});

//var rwtopt = new RewriteOptions()
//             .AddRewrite("^dashboardreport/_blazor/(.+)", "_blazor/$1", true);
//var rwtopt = new RewriteOptions()
//             .AddRewrite("^_blazor/(.+)", "dashboardreport/_blazor/$1", true);
//app.UseRewriter(rwtopt);

//app.Use(async (context, next) =>
//{
//    if (context.Request.Path.StartsWithSegments("/_blazor", StringComparison.OrdinalIgnoreCase))
//    {
//        var repl = context.Request.Path.ToString().Replace("/_blazor", NewBlazorHubUrl);
//        context.Request.Path = repl;
//    }
//    await next();
//});

//app.UseRewriter(new RewriteOptions()
//    .AddRewrite("^_blazor/initializer", "88.88.8.70/dashboardreport/_blazor/initializer", skipRemainingRules: true));

//app.UseRouting();
app.UseAntiforgery();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//    // ... 
//});
//app.MapBlazorHub(NewBlazorHubUrl);
//app.MapFallbackToPage("/_Host");

app.Run();

static IConfiguration ResolveSpecificReportingConfiguration(IWebHostEnvironment environment)
{
    // If a specific configuration needs to be passed to the reporting engine, add it through a new IConfiguration instance.
    var reportingConfigFileName = Path.Combine(environment.ContentRootPath, "reportingAppSettings.json");
    return new ConfigurationBuilder()
        .AddJsonFile(reportingConfigFileName, true)
        .Build();
}