using Microsoft.EntityFrameworkCore;
using NeYasandi.Infrastructure;
using NeYasandi.Infrastructure.Persistence;
using Serilog;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

//AppDbContext 
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddInfrastructure(builder.Configuration);

builder.Host.UseSerilog((ctx, config) =>
    config.ReadFrom.Configuration(ctx.Configuration)
          .WriteTo.Console());
var app = builder.Build();


app.UseHttpsRedirection();


//redis healht check
app.MapGet("/health/redis", async (IConnectionMultiplexer redis) =>
{
    var db = redis.GetDatabase();
    var pong = await db.PingAsync();

    return Results.Ok(new { redis = "up", latency = $"{pong.TotalMilliseconds}ms" });
});

//RabbitMq health check

app.Run();

