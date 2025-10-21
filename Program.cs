using Microsoft.EntityFrameworkCore;
using NatureApi2.Data; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi(); 

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// --------------------
// Middleware
// --------------------

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); 
    app.MapOpenApi();                 
}

app.UseCors("AllowAngular");

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();