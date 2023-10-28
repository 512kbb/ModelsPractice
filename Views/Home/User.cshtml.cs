using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ModelsPractice.Views.Home
{
    public class User : PageModel
    {
        private readonly ILogger<User> _logger;

        public User(ILogger<User> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}