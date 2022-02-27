﻿namespace MVCOrderManagmentUi.Data.DTOs
{
    public class DashboardDTO
    {
        public decimal PotentialSales { get; set; }
        public int ActiveCarts { get; set; }
        public int ItemsInCarts { get; set; }
        public dynamic MostAddedItemToCart { get; set; }
        public string LeastAddedItemToCart { get; set; }

        public dynamic ShoppingCarts { get; set; } 
    }
}
