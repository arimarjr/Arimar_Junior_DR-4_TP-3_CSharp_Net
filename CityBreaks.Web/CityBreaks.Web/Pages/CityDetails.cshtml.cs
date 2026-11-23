// Exercício: 8, 11
using CityBreaks.Web.Models;
using CityBreaks.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Web.Pages
{
    public class CityDetailsModel : PageModel
    {
        private readonly ICityService _cityService;
        private readonly IPropertyService _propertyService;

        public CityDetailsModel(ICityService cityService, IPropertyService propertyService)
        {
            _cityService = cityService;
            _propertyService = propertyService;
        }

        public City City { get; set; } = null!;

        public async Task<IActionResult> OnGetAsync(string name)
        {
            var city = await _cityService.GetByNameAsync(name);
            if (city == null)
            {
                return NotFound();
            }

            City = city;
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(string name, int id)
        {
            await _propertyService.DeleteAsync(id);
            return RedirectToPage(new { name });
        }
    }
}
