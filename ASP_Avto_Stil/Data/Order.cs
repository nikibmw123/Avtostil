namespace ASP_Avto_Stil.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Clients { get; set; }
        public int PartsId { get; set; }
        public Part Parts { get; set; } 
        public int PartQuantity { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
