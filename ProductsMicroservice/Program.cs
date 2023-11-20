using ProductsMicroservice.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add database context
builder.Services.AddDbContext<DatabaseContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.Run();