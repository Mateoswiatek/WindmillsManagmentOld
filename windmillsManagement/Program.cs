var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IWindmillServices, WindmillServices>();
// tutaj dodajemy naszą konfigurację większą?


// uruchamianie servera
var app = builder.Build();

// Configure the HTTP request pipeline.
// czy jest w trybie developerksim
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage(); // wywala nam całe wyjątki
}

app.UseHttpsRedirection(); // używa Https
app.UseStaticFiles(); // w pliku wwwroot są statyczne pliki

app.UseRouting();

app.UseAuthorization(); // ustawiamy autoryzację

app.MapControllerRoute( // endpointy
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // wystawienie servera, api.