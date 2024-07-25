namespace DefaultTechnique.Data.OneToOne
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Passport Passport { get; set; }
    }
}
