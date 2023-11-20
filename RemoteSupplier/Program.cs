using RemoteSupplier.Persistance;
using RemoteSupplier.Persistance.Implementation;
using RemoteSupplier.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<IDatabaseService, DatabaseService>();

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<ProductService>();
app.Run();
