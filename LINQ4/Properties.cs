namespace LINQ4
{
    public abstract class Properties
    {
        public int BookingId { get; set; }
        public int SeatNumber { get; set; }
        public string? MovieName { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string? Place { get; set; }
        public string? Language { get; set; }
        public int Price { get; set; }
        public abstract Stack<GetDetails> Create();
        public abstract void Read();
        public abstract void Check();
        public abstract bool NullCheckAndCount();
    }
}
