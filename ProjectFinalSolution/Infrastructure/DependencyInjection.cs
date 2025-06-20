﻿using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IReservationService, ReservationService>();

        return services;
    }
}
