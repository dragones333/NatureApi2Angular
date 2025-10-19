var builder = WebApplication.CreateBuilder(args);

// --------------------
// Servicios
// --------------------
builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi(); 


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy
            .WithOrigins("http://localhost:4200") 
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// --------------------
// Middleware
// --------------------
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); 
}

app.UseCors("AllowAngular");  
app.UseHttpsRedirection();

app.MapControllers(); 

app.Run();