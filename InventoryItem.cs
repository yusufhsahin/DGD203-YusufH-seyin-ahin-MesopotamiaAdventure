class InventoryItem
{
    public string Name { get; }
    public string Description { get; }

    public InventoryItem(string name, string description)
    {
        Name = name;
        Description = description;
    }
}