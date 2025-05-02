
using Blibrary.Shared.Extensions;
using Blibrary.Shared.Services.CMSServices;
using Blibrary.Shared.Services.ToastService;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddCommonServices(new Uri("https://localhost:7044"));

builder.Services.AddToast(options =>
{
    options.Position = ToastPosition.Top | ToastPosition.Right;
    options.Duration = 3000;
});

await builder.Build().RunAsync();
