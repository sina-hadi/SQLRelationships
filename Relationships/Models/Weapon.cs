using System.Text.Json.Serialization;

namespace EntityFramework7Relationships.Models
{
    // 1 : N Relationship
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; }
    }
}

// Weapons are connected to Character and deleting Character will deletes Weapons too, not reverse!