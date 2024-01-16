using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThAmCo.Staff.Models;
using ThAmCo.Staff.Services;

namespace ThAmCo.Staff.Pages
{
    public class IndexModel : PageModel
    {
            private readonly ILogger<IndexModel> _logger;
            private FakeOrdersService _ordersService;
            public Task<List<OrderGetDto>> orders;

            public IndexModel(ILogger<IndexModel> logger)
            {
                _logger = logger;
			    _ordersService = new FakeOrdersService();
            }

            public void OnGet()
            {
                orders = _ordersService.GetOrdersAsync();
            }
	}
    }