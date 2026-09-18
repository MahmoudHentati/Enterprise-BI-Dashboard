using EntrepriseDashboard.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers & API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// CORS — autoriser le front Blazor
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorFront", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Injection du service cube
builder.Services.AddScoped<CubeAnalysisService>();

var app = builder.Build();

app.UseCors("AllowBlazorFront");

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
