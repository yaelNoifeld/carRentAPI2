namespace carRentalApi
{
    public class Rent
    {
        public int id { get; set; }
        public Car car { get; set; }
        public Renter renter { get; set; }
    }
}
