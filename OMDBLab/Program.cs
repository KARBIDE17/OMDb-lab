using OMDBLab.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddHttpClient<OMDBApiService>(o =>
	{
	//string apiKey = builder.Configuration.GetValue<string>("OMDBApiService:f63db6e");
	o.BaseAddress = new Uri("http://www.omdbapi.com/?apikey=f63db6e&");
	//o.DefaultRequestHeaders.Add("X-Api-Key", apiKey);


});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}


//OMDB API key - f63db6e


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
