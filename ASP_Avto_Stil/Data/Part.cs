namespace ASP_Avto_Stil.Data
{
    public class Part
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Categorie Categories { get; set; }
        public string Description { get; set; }
        public int BrandsModelId { get; set; }
        public BrandModel BrandModels { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }

      public ICollection<Order> Orders { get; set; }
    }
}
