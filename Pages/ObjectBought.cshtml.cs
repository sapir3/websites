using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEBSITE.Pages
{
    public class BoughtModel : PageModel
    {
        private readonly ILogger<BoughtModel> _logger;

        public BoughtModel(ILogger<BoughtModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
