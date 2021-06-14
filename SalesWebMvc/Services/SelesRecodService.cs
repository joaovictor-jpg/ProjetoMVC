﻿using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SelesRecodService
    {
        private readonly SalesWebMvcContext _context;

        public SelesRecodService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SelesRecord>> FindByDateAsyng(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SelesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
