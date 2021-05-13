using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEBSITE.Pages
{
    public class MarketModel : PageModel
    {
        private readonly ILogger<MarketModel> _logger;

        public MarketModel(ILogger<MarketModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
