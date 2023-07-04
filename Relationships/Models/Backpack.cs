using System.Text.Json.Serialization;

namespace EntityFramework7Relationships.Models
{
    // 1 : 1 Relationship
    public class Backpack
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; }
    }
}

// Backpack is connected to Character and deleting Character will delete Backpack too, not reverse!