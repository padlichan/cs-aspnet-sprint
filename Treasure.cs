using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ASPNET
{
    public class Treasure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type {  get; set; }   
        public string Material { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Rarity { get; set; }
        public string Origin { get; set; }
    }
}
