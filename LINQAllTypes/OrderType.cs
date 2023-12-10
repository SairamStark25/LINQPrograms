namespace LINQAllTypes
{
    public class OrderProperties
    {
        public int Id { get; set; }
        public string? OrderName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public List<string>? Items { get; set; }

        public static List<OrderProperties> orders1 = new List<OrderProperties>
        {
            new OrderProperties { Id = 1, OrderName = "Pizza", Quantity = 2, Price = 300.36f },
            new OrderProperties { Id = 2, OrderName = "Veg rice", Quantity = 2, Price = 400.87f },
            new OrderProperties { Id = 3, OrderName = "Biriyani", Quantity = 5, Price = 670.86f },
            new OrderProperties { Id = 4, OrderName = "Chicken gravy", Quantity = 1, Price = 244.23f },
            new OrderProperties { Id = 5, OrderName = "Noodles", Quantity = 1, Price = 455.64f },
            new OrderProperties { Id = 6, OrderName = "Noodles", Quantity = 1, Price = 450.64f },
        };

        public static List<OrderProperties> orders2 = new List<OrderProperties> // created for SelectMany
        {
            new OrderProperties { Id = 1, OrderName = "Pizza", Quantity = 2, Price = 300.36f, Items = new List<string> { "Cheese", "Tomato", "Crust" } },
            new OrderProperties { Id = 2, OrderName = "Veg rice", Quantity = 2, Price = 400.87f, Items = new List<string> { "Rice", "Vegetables" } },
            new OrderProperties { Id = 3, OrderName = "Biriyani", Quantity = 5, Price = 670.86f, Items = new List<string> { "Rice", "Chicken", "Spices" } },
            new OrderProperties { Id = 4, OrderName = "Chicken gravy", Quantity = 1, Price = 244.23f, Items = new List<string> { "Chicken", "Sauce" } },
            new OrderProperties { Id = 5, OrderName = "Noodles", Quantity = 1, Price = 455.64f, Items = new List<string> { "Noodles", "Vegetables" } },
            new OrderProperties { Id = 6, OrderName = "Noodles", Quantity = 1, Price = 450.64f, Items = new List<string> { "Noodles", "Sauce" } },
        };
    }
}
