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
    public class DetailsModel : PageModel
    {
        private readonly Neighbourhood_Alert.Models.Neighbourhood_AlertContext _context;

        public DetailsModel(Neighbourhood_Alert.Models.Neighbourhood_AlertContext context)
        {
            _context = context;
        }

        public CrimesReported CrimesReported { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CrimesReported = await _context.CrimesReported.FirstOrDefaultAsync(m => m.IncidentNo == id);

            if (CrimesReported == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
