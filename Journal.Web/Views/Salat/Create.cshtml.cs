using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Journal.Web.Data;
using Journal.Web.Models.Salat;

namespace Journal.Web.Views.Salat
{
    public class CreateModel : PageModel
    {
        private readonly Journal.Web.Data.JournalWebContext _context;

        public CreateModel(Journal.Web.Data.JournalWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SalatModel SalatModel { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SalatModel.Add(SalatModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
