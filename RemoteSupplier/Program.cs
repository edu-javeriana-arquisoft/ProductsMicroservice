using RemoteSupplier.Persistance;
using RemoteSupplier.Persistance.Implementation;
using RemoteSupplier.Services;
using RemoteSupplier.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<IDatabaseService, DatabaseService>();
builder.Services.AddScoped<IMockService<Arquisoft.Remote.Product>, ProductMockService>();

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<ProductService>();
app.Run();
