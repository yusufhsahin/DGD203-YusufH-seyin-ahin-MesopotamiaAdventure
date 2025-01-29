class Location
{
    public (int, int) Coordinates { get; }
    public string Description { get; }
    public string NPC { get; }
    
    public Location(string name, string description, List<InventoryItem> items = null, string npc = null, bool hasPuzzle = false, string requiredItem = null)
    {
        Description = $"{name}\n\n{description}";
        NPC = npc;
    }

    public void Display(Player player)
    {
        Console.Clear();
        Console.WriteLine(Description);
        if(NPC != null) Console.WriteLine($"\nYou see a {NPC}");
        Console.WriteLine("\n[Commands: n/s/e/w, take, solve puzzle, i]");
    }
}