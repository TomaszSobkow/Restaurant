namespace Restaurant.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public bool hasDelivery { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

    }
}