using mysiteapi.Models;
using mysiteapi.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<DiaryStoreDatabaseSettings>(
    builder.Configuration.GetSection("DiaryStoreDatabase"));
// Add services to the container.
builder.Services.AddSingleton<DiaryService>();
builder.Services.Configure<StudentStoreDatabaseSettings>(
builder.Configuration.GetSection("StudentStoreDatabase"));
// Add services to the container.
builder.Services.AddSingleton<StudentService>();
builder.Services.Configure<CodeStoreDatabaseSettings>(
    builder.Configuration.GetSection("CodeStoreDatabase"));
// Add services to the container.
builder.Services.AddSingleton<CodeService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy
        (name: "myCors",
            builde =>
            {
                builde.WithOrigins("*", "*", "*")
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
            }
        );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("myCors");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
