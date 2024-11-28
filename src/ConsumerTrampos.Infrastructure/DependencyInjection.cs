using ConsumerTrampos.Application.Common.Interfaces;
using ConsumerTrampos.Infrastructure.Persistence;
using ConsumerTrampos.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsumerTrampos.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Configurar a conexão com o banco de dados
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Registrar o repositório
        services.AddScoped<IConsumerRepository, ConsumerRepository>();

        return services;
    }
}