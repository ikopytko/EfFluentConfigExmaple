namespace Test
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
    }
    
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    
        public virtual Address DefaultAddress { get; set; }
        public virtual Address BillingAddress { get; set; }
    }
    
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public virtual Address DeliveryAddress { get; set; }
    }
}