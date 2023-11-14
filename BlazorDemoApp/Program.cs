using BlazorDemoApp.Contracts;
using BlazorDemoApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
OnConfigure(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

static void OnConfigure(IServiceCollection services)
{
    services.AddScoped<IContactService, ContactService>();
    services.AddSingleton<WeatherForecastService>();
    services.AddRazorPages();
    services.AddServerSideBlazor();

}