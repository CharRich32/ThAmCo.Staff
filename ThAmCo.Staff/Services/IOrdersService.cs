using ThAmCo.Staff.Models;

namespace ThAmCo.Staff.Services
{
	public interface IOrdersService
	{
		public Task<List<OrderGet>> GetOrdersAsync();
		public Task<OrderGet?> GetOrderAsync(int id);
		public Task<List<OrderGet>> GetOrdersByStatusAsync(OrderStatus orderStatus);
		public Task UpdateOrderStatusAsync(int id, OrderUpdate order);

	}
}