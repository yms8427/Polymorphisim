namespace BilgeAdam.OOP.Common.GenericInterface.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
    }
}