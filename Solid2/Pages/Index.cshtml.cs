using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Solid2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMenu _menu;
        private readonly IBreakfastMenu _bmenu;
        private readonly IDinnerMenu _dmenu;

        public IndexModel(ILogger<IndexModel> logger, IMenu menu, IBreakfastMenu bmenu, IDinnerMenu dmenu)
        {
            _logger = logger;
            _menu = menu;
            _bmenu = bmenu;
            _dmenu = dmenu;
        }

        public void OnGet()
        {
            
        }

        //Constructorda dependency injection işlemi yapıldı. 
        //Cheflerin yapabildikleri menulere göre metodlar interface segregation prensibi baz alınarak oluşturuldu.
        public void BreakfastChef()
        {
            _bmenu.MakeGozleme();
        }

        public void DinnerChef()
        {
            _dmenu.MakeKebab();
        }

        public void MasterChef()
        {
            _menu.MakeKebab();
            _menu.MakeGozleme();
        }
    }
}
