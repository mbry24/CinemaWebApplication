﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApplication.Core.Domain
{
    public class Hall
    {
        public Guid HallId { get; set; }
        public string Name { get; set; }
        public int RowsNumber { get; set; }
        public int SeatsInRowNumber { get; set; }
        public ICollection<Filmshow> Filmshows { get; set; }
        public ICollection<Seat> Seats { get; set; }

    }
}
