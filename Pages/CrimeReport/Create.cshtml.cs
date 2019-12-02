using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Neighbourhood_Alert.Models;

namespace Neighbourhood_Alert.Pages.CrimeReport
{
    public class CreateModel : PageModel
    {
        private readonly Neighbourhood_Alert.Models.Neighbourhood_AlertContext _context;

        public CreateModel(Neighbourhood_Alert.Models.Neighbourhood_AlertContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CrimesReported CrimesReported { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CrimesReported.Add(CrimesReported);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
