﻿using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Services;
using Microsoft.Extensions.DependencyInjection;
using slambot.Common.Configuration;
using System.Threading.Tasks;

namespace DiscordBot
{
	public class Startup
	{
		public Startup(string[] args)
		{
		}

		public static async Task RunAsync(string[] args)
		{
			Startup startup = new Startup(args);
			await startup.RunAsync();
		}

		public async Task RunAsync()
		{
			ServiceCollection services = new ServiceCollection();
			ConfigureServices(services);

			ServiceProvider provider = services.BuildServiceProvider();
			provider.GetRequiredService<CommandHandlingService>();
			provider.GetRequiredService<LoggingService>();
			await provider.GetRequiredService<StartupService>().StartAsync();

			await Task.Delay(-1);
		}

		private void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton(new DiscordSocketClient(new DiscordSocketConfig
			{
				LogLevel = LogSeverity.Verbose,
				MessageCacheSize = DiscordBotConfiguration.CacheMessagesPerChannel
			}))
			.AddSingleton(new CommandService(new CommandServiceConfig
			{
				LogLevel = LogSeverity.Verbose,
				DefaultRunMode = RunMode.Async,
			}))
			.AddSingleton<CommandHandlingService>()
			.AddSingleton<StartupService>()
			.AddSingleton<LoggingService>();
		}
	}
}
