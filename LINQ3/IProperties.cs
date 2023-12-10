namespace LINQ3
{
    public interface IProperties
    {
        public int CoffeeId { get; set; }
        public string? CustomerName { get; set; }
        public string? CoffeeName { get; set; }
        public int Quantity { get; set; }
        public bool Sugar { get; set; }
        public decimal Price { get; set; }
        public Queue<IProperties> Create();
        public void Read();
        public void Check();
        public bool NullCheckAndCount();
    }
}
