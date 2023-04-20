using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment2.Model;

namespace Assignment2.Pages.MemberManagerment
{
    public class DetailsModel : PageModel
    {
        private readonly Assignment2.Model.PRN221_As02Context _context;

        public DetailsModel(Assignment2.Model.PRN221_As02Context context)
        {
            _context = context;
        }

      public Account Account { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FirstOrDefaultAsync(m => m.AccountId == id);
            if (account == null)
            {
                return NotFound();
            }
            else 
            {
                Account = account;
            }
            return Page();
        }
    }
}
