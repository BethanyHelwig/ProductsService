namespace OrderService.Models
{
    using ProductsService.Models;
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
    }

}
