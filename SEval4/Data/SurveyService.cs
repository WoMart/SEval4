using Microsoft.EntityFrameworkCore;
using SEval4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data
{
    public class SurveyService
    {
        private readonly SEvalDBContext _context;

        public SurveyService(SEvalDBContext context)
        {
            _context = context;
        }

        public async Task<List<AgeGroup>> GetAgeGroupsAsync()
        {
            return await _context.AgeGroup.ToListAsync();
        }
    }
}
