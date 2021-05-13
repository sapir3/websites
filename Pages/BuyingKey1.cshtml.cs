using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEBSITE.Pages
{
    public class BuyingModel : PageModel
    {
        private readonly ILogger<BuyingModel> _logger;

        public BuyingModel(ILogger<BuyingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
