using ThAmCo.Staff.Models;

namespace ThAmCo.Staff.Services
{
	public class FakeOrdersService : IOrdersService
	{
		private readonly List<OrderGet> _orders = new() {
			new OrderGet { Id = 1, CustomerId = 1, SubmittedDate = DateTime.Now, OrderDetails = new List<Order>
					{ new Order { OrderId = 1, ProductId = 1, Quantity = 10, UnitPrice = 0.05f } } },
		};
		public async Task<List<OrderGet>> GetOrdersAsync()
		{
			return await Task.FromResult(_orders);
		}

		public async Task<OrderGet> GetOrderAsync(int id)
		{
			var order = _orders.FirstOrDefault(x => x.Id == id);
			return await Task.FromResult(order);
		}

		public async Task<List<OrderGet>> GetOrdersByStatusAsync(OrderStatus orderStatus)
		{
			var orders = _orders.Where(x => x.Status == orderStatus);
			return await Task.FromResult(orders.ToList());
		}

		public async Task UpdateOrderStatusAsync(int id, OrderUpdate orderUpdateDto)
		{
			return;
		}

	}
}