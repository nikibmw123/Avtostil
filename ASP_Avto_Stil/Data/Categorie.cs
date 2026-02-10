namespace ASP_Avto_Stil.Data
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Part> Parts { get; set; }

    }
}
