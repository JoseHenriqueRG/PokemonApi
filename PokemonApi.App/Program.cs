using PokemonApi.App.Components;
using PokemonApi.Business;
using PokemonApi.Domain.Interfaces;
using PokemonApi.Infra.ApiPoke;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.InstanceName = "Redis Instance";
    options.Configuration = "127.0.0.1:6379";
});

// Registre a implementação de IPokeApi
builder.Services.AddScoped<IPokeApi, PokeApi>();
builder.Services.AddScoped<IPokeApiBusiness, PokeApiBusiness>();

builder.Services.AddRadzenComponents();

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
    .AddInteractiveServerRenderMode();

app.Run();
