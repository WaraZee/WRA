using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WRA;
using WRA.Services;
using WRA.Services.Interfaces;
using WRA.Store;

WebAssemblyHostBuilder? builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<StateContainer>();

// 計算用サービス
builder.Services.AddSingleton<IAllRateService, AllRateService>();
builder.Services.AddSingleton<ITrustworthinessService, TrustworthinessService>();
builder.Services.AddSingleton<IWinRateService, WinRateService>();
builder.Services.AddSingleton<IShowRateService, ShowRateService>();
builder.Services.AddSingleton<ITrieceRateService, TrierceRateService>();
builder.Services.AddSingleton<ITrioRateService, TrioRateService>();

await builder.Build().RunAsync();