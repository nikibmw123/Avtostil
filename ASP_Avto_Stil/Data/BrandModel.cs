namespace ASP_Avto_Stil.Data
{
    public class BrandModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public string Model {  get; set; }  
        public string Description { get; set; }

        public DateTime RegisterOn { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
