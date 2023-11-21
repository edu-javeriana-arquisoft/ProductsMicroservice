using Arquisoft.Remote;
using ProductsMicroservice.Services;
using ProductsMicroservice.Services.Implementation;
using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add system services
builder.Services.AddGrpc();
builder.Services.AddDiscoveryClient(builder.Configuration);

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

app.Map("/info", () =>
	new StringType { Value = "Hello from ProductsMicroservice!" }
);

app.MapControllers();
app.Run();