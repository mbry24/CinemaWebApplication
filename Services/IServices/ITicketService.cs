﻿using CinemaWebApplication.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApplication.Services.IServices
{
    public interface ITicketService
    {
        Task AddAsync(TicketDTO ticketDTO);
        Task<TicketDTO> GetAsync(Guid id);
        Task<IEnumerable<TicketDTO>> GetAllAsync();
        Task Update(TicketDTO ticketDTO);
        Task DeleteAsync(TicketDTO ticketDTO);

        Task AddTicketsAsync(IEnumerable<TicketDTO> ticketsToAdd);
        Task<IEnumerable<TicketDTO>> GetAllUserTickets(Guid id);
    }
}
