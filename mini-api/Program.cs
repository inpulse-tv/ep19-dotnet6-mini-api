var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(setup => setup.AddDefaultPolicy(policy => policy.WithOrigins("http://localhost:9000", "https://sandwichpouletmayonnaise.com")));
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

var app = builder.Build();

app.UseCors();
app.MapControllers();

app.Run();