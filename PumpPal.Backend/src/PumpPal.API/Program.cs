var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices();
var app = builder.Build();
app.AddServices();
app.Run();
