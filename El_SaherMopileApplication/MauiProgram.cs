﻿using Blazored.LocalStorage;
using El_SaherMopileApplication.Data;
using El_SaherMopileApplication.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.DependencyInjection;

namespace El_SaherMopileApplication
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();

			
#endif

			builder.Services.AddSingleton<WeatherForecastService>();
			builder.Services.AddScoped<HttpClient>();
			builder.Services.AddScoped<HttpResponseMessage>();
			builder.Services.AddScoped<IManager, Manager>();
			//builder.Services.AddSingleton<NavigationManager>();
			builder.Services.AddBlazoredLocalStorage();
            return builder.Build();
		}
	}
}