using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEBSITE.Pages
{
    public class Buying2Model : PageModel
    {
        private readonly ILogger<Buying2Model> _logger;

        public Buying2Model(ILogger<Buying2Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
