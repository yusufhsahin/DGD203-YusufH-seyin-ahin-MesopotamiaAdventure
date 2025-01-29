using System.Collections.Generic;

class Player
{
    public (int X, int Y) Position { get; private set; }
    public List<InventoryItem> Inventory { get; } = new List<InventoryItem>();

    public Player(int x, int y) => Position = (x, y);

    public void Move(int dx, int dy) => Position = (Position.X + dx, Position.Y + dy);
    
    public void AddItem(InventoryItem item) => Inventory.Add(item);
    
    public bool HasItem(string itemName) => 
        Inventory.Exists(i => i.Name.Equals(itemName, System.StringComparison.OrdinalIgnoreCase));
    
    public void ShowInventory()
    {
        Console.WriteLine("Inventory:");
        foreach(var item in Inventory)
            Console.WriteLine($"- {item.Name}");
        Console.ReadKey();
    }
}