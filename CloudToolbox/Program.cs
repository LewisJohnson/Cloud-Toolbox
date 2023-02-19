using CloudToolbox.Data;
using CloudToolbox.Services;
using Microsoft.AspNetCore.ResponseCompression;

namespace CloudToolbox;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddRazorPages();
		builder.Services.AddServerSideBlazor();
		builder.Services.AddHttpContextAccessor();
		builder.Services.AddResponseCompression(options =>
		{
			options.EnableForHttps = true;
			options.Providers.Add<BrotliCompressionProvider>();
			options.Providers.Add<GzipCompressionProvider>();
		});

		builder.Services.AddSingleton<CalculatorCollectionService>();
		builder.Services.AddScoped<NotFoundService>();

		var app = builder.Build();

		app.UseResponseCompression();

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Error");
		}

		app.UseStaticFiles();

		app.UseRouting();

		app.MapBlazorHub();
		app.MapFallbackToPage("/_Host");

		app.MapGet("/sitemap.xml", Sitemap.Generate);

		app.Run();
	}
}
