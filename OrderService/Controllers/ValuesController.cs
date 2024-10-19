using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private static readonly List<Order> Orders = new();

    [HttpPost]
    public ActionResult<Order> CreateOrder([FromBody] Order order)
    {
        order.Id = Orders.Count + 1; // Simple ID generation
        Orders.Add(order);
        return CreatedAtAction(nameof(CreateOrder), order);
    }

    [HttpGet]
    public ActionResult<List<Order>> GetOrders() => Orders;
}

