using Blibrary.Components;
using Blibrary.Client;
using Serilog;
using Serilog.Core;
using Serilog.Exceptions;
using Blibrary.Shared.Services;
using Blibrary.Services;
using Blibrary.Shared.Services.CMSServices;
using Blibrary.Shared.Services.ToastService;
using Blibrary.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

Serilog.Core.Logger logger = new LoggerConfiguration()
    .MinimumLevel.Warning()
    .Enrich.WithExceptionDetails()
    .Enrich.FromLogContext()
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm} {Level:u3}] {Message:lj}{NewLine}{LogContext}{NewLine}{DemystifiedStackTraces:lj}{NewLine}{ExceptionDetails:lj}", restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug)
    .CreateLogger();

Log.Logger = logger;
builder.Logging.AddSerilog(logger);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddCommonServices(new Uri(builder.Configuration["BaseUrl"] ?? ""));
builder.Services.AddControllers();
builder.Services.AddToast(options =>
{
    options.Position = ToastPosition.Top | ToastPosition.Right;
    options.Duration = 3000;
});

builder.Services.AddSassCompilerCore();
builder.Services.AddTransient<BootstrapStyleService>();
//builder.Services.AddDnsSrvServiceEndpointProvider();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Blibrary.Client._Imports).Assembly);

app.MapControllers();
//app.UseCors();
app.Run();
