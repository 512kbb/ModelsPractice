using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ModelsPractice.Views.Home
{
    public class Users : PageModel
    {
        private readonly ILogger<Users> _logger;

        public Users(ILogger<Users> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}