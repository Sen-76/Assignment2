using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment2.Model;

namespace Assignment2.Pages.NewFolder
{
    public class IndexModel : PageModel
    {
        private readonly Assignment2.Model.PRN221_As02Context _context;

        public IndexModel(Assignment2.Model.PRN221_As02Context context)
        {
            _context = context;
        }

        public IList<Supplier> Supplier { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Suppliers != null)
            {
                Supplier = await _context.Suppliers.ToListAsync();
            }
        }
    }
}
