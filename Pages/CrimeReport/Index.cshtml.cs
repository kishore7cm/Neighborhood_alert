using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Neighbourhood_Alert.Models;

namespace Neighbourhood_Alert.Pages.CrimeReport
{
    public class IndexModel : PageModel
    {
        private readonly Neighbourhood_Alert.Models.Neighbourhood_AlertContext _context;

        public IndexModel(Neighbourhood_Alert.Models.Neighbourhood_AlertContext context)
        {
            _context = context;
        }

        public IList<CrimesReported> CrimesReported { get;set; }

        public async Task OnGetAsync()
        {
            CrimesReported = await _context.CrimesReported.ToListAsync();
        }
    }
}
