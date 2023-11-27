using BlazorShop.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var BaseUrl = "https://localhost:7110";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(BaseUrl) });

await builder.Build().RunAsync();
