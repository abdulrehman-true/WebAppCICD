using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppCICD.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configurations;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configurations)
        {
            _logger = logger;
            _configurations = configurations;
        }

        public void OnGet()
        {
            ViewData["KeyValue"] = _configurations["KeyValue"]; 
        }
    }
}
