﻿using CinemaWebApplication.Core;
using CinemaWebApplication.Core.Database;
using CinemaWebApplication.Core.Domain;
using CinemaWebApplication.Core.Repositories;
using CinemaWebApplication.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApplication.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        public IClientRepository ClientRepository { get; }
        public IEmployeeRepository EmployeeRepository { get; }
        public IFilmRepository FilmRepository { get; }
        public IFilmshowRepository FilmshowRepository { get; }
        public IHallRepository HallRepository { get; }
        public ITicketRepository TicketRepository { get; }


        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            ClientRepository = new ClientRepository(_context);
            EmployeeRepository = new EmployeeRepository(_context);
            FilmRepository = new FilmRepository(_context);
            FilmshowRepository = new FilmshowRepository(_context);
            HallRepository = new HallRepository(_context);
            TicketRepository = new TicketRepository(_context);

        }
        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
