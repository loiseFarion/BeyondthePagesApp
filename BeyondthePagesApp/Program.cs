using BeyondthePagesAdd.Repositories;
using BeyondthePagesApp.Auth;
using BeyondthePagesApp.Client;
using BeyondthePagesApp.Components;
using BeyondthePagesApp.Components.Account;
using BeyondthePagesApp.Data;
using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Interfaces.Services;
using BeyondthePagesApp.Library.Domain;
using BeyondthePagesApp.Repositories;
using BeyondthePagesApp.Service;
using BeyondthePagesApp.State;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddDbContextFactory<AddDbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConection"]));

builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();
builder.Services.AddScoped<ITimeRegistrationDataService, TimeRegistrationDataService>();
builder.Services.AddScoped<IJobCategoryDataService, JobCategoryDataService>();
builder.Services.AddScoped<ICountryDataService, CountryDataService>();

builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<ITimeRegistrationRepository,TimeRegistrationRepository>();
builder.Services.AddScoped<ICountryRepository,CountryRepository>();
builder.Services.AddScoped<IJobCategoryRepository,JobCategoryRepository>();

builder.Services.AddScoped<ApplicationState>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
}).AddIdentityCookies();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true )
    .AddEntityFrameworkStores<AddDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>,IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BeyondthePagesApp.Client._Imports).Assembly);

app.MapAdditionalIdentityEndpoints();

app.MapGet("api/employee", async(IEmployeeDataService employeeDataService) => await employeeDataService.GetAllEmployess());
app.Run();
