﻿using CinemaWebApplication.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApplication.Services.IServices
{
    public interface IFilmshowService
    {
        Task AddAsync(FilmshowDTO filmshowDTO);
        Task<FilmshowDTO> GetAsync(Guid id);
        Task<IEnumerable<FilmshowDTO>> GetAllAsync();
        Task Update(FilmshowDTO filmshowDTO);
        Task DeleteAsync(FilmshowDTO filmshowDTO);
        Task<IEnumerable<FilmshowDTO>> GetAllFilmshowsOfFilmAsync(Guid id);
        Task<IEnumerable<FilmshowDTO>> GetAllFilmshowsOfFilmAsync(Guid id, DateTime dateTime);
    }
}
