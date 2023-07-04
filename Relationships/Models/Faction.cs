using System.Text.Json.Serialization;

namespace EntityFramework7Relationships.Models
{
    // N : N Relationship
    public class Faction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Character> Characters { get; set; }
    }
}

// Create CharacterFaction table by its own!
// If you want to customize N : N table, you should bluid the table by your own!