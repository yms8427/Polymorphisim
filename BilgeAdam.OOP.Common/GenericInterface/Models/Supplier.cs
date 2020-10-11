namespace BilgeAdam.OOP.Common.GenericInterface.Models
{
    public class Supplier : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Info { get { return $"{Name} - {Phone}"; } }
    }
}