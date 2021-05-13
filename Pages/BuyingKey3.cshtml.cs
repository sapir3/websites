using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEBSITE.Pages
{
    public class Buying3Model : PageModel
    {
        private readonly ILogger<Buying3Model> _logger;

        public Buying3Model(ILogger<Buying3Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
