using Aplication;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

/*ServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<FluxoDaAplicacao>();

ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
var fluxo = serviceProvider.GetRequiredService<FluxoDaAplicacao>();
fluxo.Execute();*/
FluxoDaAplicacao fluxo =new FluxoDaAplicacao();
fluxo.Execute();


