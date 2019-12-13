﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApplication.Services.DTO
{
    public class SeatFilmshowDTO
    {

        public Guid SeatId { get; set; }

        [Required]
        public int SeatNumber { get; set; }

        [Required]
        public int Row { get; set; }

        [Required]
        public bool IsOccupied { get; set; }

        [Required]
        public Guid HallId { get; set; }
    }
}
