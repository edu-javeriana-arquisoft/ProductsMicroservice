using ProductsMicroservice.Persistance;
using ProductsMicroservice.Services;
using ProductsMicroservice.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add database context
builder.Services.AddDbContext<DatabaseContext>();

// Add GRPC services
builder.Services.AddGrpc();

// Add scoped services
builder.Services.AddScoped<IDatabaseService, DatabaseService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.Run();