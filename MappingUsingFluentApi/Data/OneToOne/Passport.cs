namespace DefaultTechnique.Data.OneToOne
{
    public class Passport
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public int PersonId { get; set; } // Foreign key
        public Person Person { get; set; }
    }
}
