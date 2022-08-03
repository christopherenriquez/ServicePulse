using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ServicePulse.Blazor;
using ServicePulse.Blazor.Pages;
using ServicePulse.Blazor.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.RegisterCustomElement<NavigationMenu>("sp-navmenu");
builder.RootComponents.RegisterCustomElement<Footer>("sp-footer");
builder.RootComponents.RegisterCustomElement<Heartbeat>("my-heartbeat");

await builder.Build().RunAsync();
