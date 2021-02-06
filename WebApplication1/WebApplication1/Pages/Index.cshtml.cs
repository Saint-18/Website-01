using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }


        [BindProperty]
        public int num1 { get; set; }

        [BindProperty]
        public int num2 { get; set; }

        [BindProperty]
        public string num3 { get; set; }


        public void OnGet()
        {
            
        }


        public void OnPost()
        {
            var mynum1 = this.num1;
            var mynum2 = this.num2;

            var mynum3 = num1 + num2;

            num3 = mynum3.ToString();

        }

    }




}
