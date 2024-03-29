using Microsoft.Azure.Cosmos;
using System.Configuration;
using System.Xml.Linq;
using TechChallenge.Infra.Cache.MongoDb.Cotexts;
using TechChallenge.Infra.Cache.MongoDb.Persistence;
using TechChallenge.Services.Api.Configurations;
using TechChallenge.Services.Api.Setup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ApplicationConfig.AddApplicationConfig(builder);
DomainConfig.AddDomainConfig(builder);
RepositoryConfig.AddRepositoryConfig(builder);
CacheConfig.AddCacheConfig(builder);

builder.Services.AddControllers();

SwaggerSetup.AddSwaggerSetup(builder);
CorsSetup.AddCorsSetup(builder);
JwtSetup.AddJwtSetup(builder);

var app = builder.Build();

SwaggerSetup.UseSwaggerSetup(app);
CorsSetup.UseCorsSetup(app);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }