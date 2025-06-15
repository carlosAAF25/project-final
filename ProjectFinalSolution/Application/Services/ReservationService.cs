using System;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class ReservationService : IReservationService
{
    private readonly AppDbContext _context;

    public ReservationService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> CreateReservationAsync(CreateReservationRequest request)
    {
        var reservation = new Reservation
        {
            Id = Guid.NewGuid(),
            SpaceId = request.SpaceId,
            UserId = request.UserId,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
            Purpose = request.Purpose
        };

        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();

        return reservation.Id;
    }
}
