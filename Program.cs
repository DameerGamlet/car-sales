using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Добавление сервиса для работы с базой данных
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<ICars, CarRepository>();
builder.Services.AddTransient<IAccounts, AccountRepository>();
builder.Services.AddTransient<ICarBrands, CarBrandRepository>();

var app = builder.Build();

// Конфигурация HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
  app.UseExceptionHandler("/Error");
  // The default HSTS value is 30 days. You may want to change this for
  // production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

using (var scope = app.Services.CreateScope()) {
  ApplicationDbContext dbContext =
      scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
  DBObject.Initialize(dbContext);
}

app.Run();