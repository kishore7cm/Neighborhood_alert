using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Neighbourhood_Alert.Models;

namespace Neighbourhood_Alert.Pages.CrimeReport
{
    public class EditModel : PageModel
    {
        private readonly Neighbourhood_Alert.Models.Neighbourhood_AlertContext _context;

        public EditModel(Neighbourhood_Alert.Models.Neighbourhood_AlertContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CrimesReported).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrimesReportedExists(CrimesReported.IncidentNo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CrimesReportedExists(int id)
        {
            return _context.CrimesReported.Any(e => e.IncidentNo == id);
        }
    }
}
