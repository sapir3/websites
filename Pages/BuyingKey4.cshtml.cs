using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEBSITE.Pages
{
    public class Buying4Model : PageModel
    {
        private readonly ILogger<Buying4Model> _logger;

        public Buying4Model(ILogger<Buying4Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
