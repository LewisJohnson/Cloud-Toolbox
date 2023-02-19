using CloudToolbox.Data;
using CloudToolbox.Services;

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

		builder.Services.AddSingleton<CalculatorCollectionService>();
		builder.Services.AddScoped<NotFoundService>();

		var app = builder.Build();

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
