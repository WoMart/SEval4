using Microsoft.EntityFrameworkCore;
using SEval4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data
{
    public class SurveyServices
    {
        private SurveyContext _context;

        public SurveyServices(SurveyContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<ExperienceOption>> GetExperienceOptionsAsync()
        {
            return await _context.ExperienceOption.ToListAsync();
        }
    }
}
