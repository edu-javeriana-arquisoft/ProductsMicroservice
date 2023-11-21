using ProductsMicroservice.Services;
using ProductsMicroservice.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add GRPC services
builder.Services.AddGrpc();

// Add scoped services
builder.Services.AddScoped<IDatabaseService, DatabaseService>();
builder.Services.AddScoped<SuppliersService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapControllers();
app.Run();