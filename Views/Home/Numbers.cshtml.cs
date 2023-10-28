using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ModelsPractice.Views.Home
{
    public class Numbers : PageModel
    {
        private readonly ILogger<Numbers> _logger;

        public Numbers(ILogger<Numbers> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}