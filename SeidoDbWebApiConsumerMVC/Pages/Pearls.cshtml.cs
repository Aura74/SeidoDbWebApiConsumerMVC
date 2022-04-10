using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NecklaceModels;
using SeidoDbWebApiConsumerMVC.Services;

namespace SeidoDbWebApiConsumerMVC.Pages
{
    public class PearlsModel : PageModel
    {
        //public void OnGet()
        //{
        //}
        
        ISeidoDbHttpService _httpService;
        
        public IEnumerable<Pearl> Pearls { get; set; }

        [BindProperty]
        public Necklace NewNecklaces { get; set; }

        public async Task OnGet() //public void OnGet() // Den gammla tomma utan async
        {
            //Pearls = await _httpService.GetPearls();
            //Pearls = Pearls.OrderBy(c => c.PearlID).Take(10);
        }

        public PearlsModel(ISeidoDbHttpService service)
        {
            this._httpService = service;
        }

    }
}