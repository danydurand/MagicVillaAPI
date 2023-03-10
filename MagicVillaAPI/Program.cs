using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//---------------------------------------------------------------------------
// Here we are defining the file name to store de log information and the
// rolling interval
//---------------------------------------------------------------------------
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().
//    WriteTo.File("log/villalogs.txt", rollingInterval:RollingInterval.Day).CreateLogger();

//------------------------------------------------------------------------------------
// With this line, we are asking the app to use Serilog instead the logger built-in 
//------------------------------------------------------------------------------------
//builder.Host.UseSerilog(); 

builder.Services.AddControllers(option => {
    //option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
