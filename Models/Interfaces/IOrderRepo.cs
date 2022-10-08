using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace e_commerce_app.Models.Interfaces
{
    public interface IOrderRepo
    {
        Task<HttpStatusCode> CreateAddress(Address address);

        Task<HttpStatusCode> AddOrderAsync(Order Order);

        Task<HttpStatusCode> AddOrderItemToOrderAsync(OrderItem orderItem);

        Task<Order> GetOrderByIDAsync(int id);

        Task<HttpStatusCode> UpdateOrderAsync(Order order);

        Task<HttpStatusCode> DeleteOrderAsync(int id);

        //Task<HttpStatusCode> AdminDeleteOrderAsync(int id);

        Task<List<Order>> GetRecentOrdersAsync(int n);

        Task<List<Order>> GetRecentOrdersAsync(int n, string userID);

        Task<Address> GetAddressByIDAsync(int id);

        Task<List<OrderItem>> GetOrderItemsByOrderIDAsync(int id);
    }
}
