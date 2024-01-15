using ThAmCo.Staff.Models;

namespace ThAmCo.Staff.Services
{
	public interface ICustomerService
	{
		public Task<List<CustomerGet>> GetCustomersAsync();
		public Task<CustomerGet?> GetCustomerAsync(int id);
		public Task<bool> DeleteCustomerAsync(int id);

	}
}