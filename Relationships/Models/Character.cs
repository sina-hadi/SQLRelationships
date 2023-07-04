namespace EntityFramework7Relationships.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 1 : 1
        public Backpack Backpack { get; set; }
        // 1 : N
        public List<Weapon> Weapons { get; set; }
        // N : N
        public List<Faction> Factions { get; set; }
    }
}

// Not connected to anything!