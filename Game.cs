using System;
using System.Collections.Generic;

class Game
{
    private Player _player;
    private Dictionary<(int, int), Location> _map;

    public Game()
    {
        InitializeMap();
        _player = new Player(0, 0);
    }

    private void InitializeMap()
    {
        _map = new Dictionary<(int, int), Location>
        {
            {(0, 0), new Location("The Whispering Dunes", "Golden sands stretch endlessly.", new List<InventoryItem>{new InventoryItem("Clay Tablet", "Ancient writing")}, hasPuzzle: true)},
            {(1, 0), new Location("River of Two Waters", "Tigris and Euphrates meet here.", npc: "Old Fisherman")},
            {(1, 1), new Location("The Celestial Ziggurat", "Massive pyramid with obsidian gates.", requiredItem: "Star Seal")}
        };
    }

    public void Start()
    {
        while(true)
        {
            var currentLocation = GetCurrentLocation();
            currentLocation.Display(_player);

            if(currentLocation.Coordinates == (1,1) && _player.HasItem("Star Seal"))
            {
                Console.WriteLine("\nGates open! You win!");
                Console.ReadKey();
                return;
            }

            Console.Write("\n> ");
            HandleInput(Console.ReadLine().ToLower());
        }
    }

    private void HandleInput(string input)
    {
        switch(input)
        {
            case "n": _player.Move(0, 1); break;
            case "s": _player.Move(0, -1); break;
            case "e": _player.Move(1, 0); break;
            case "w": _player.Move(-1, 0); break;
            case "i": _player.ShowInventory(); break;
            default:
                if(input == "solve puzzle") SolvePuzzle();
                else if(input == "take clay tablet") TakeItem();
                break;
        }
    }

    private void SolvePuzzle()
    {
        Console.WriteLine("Puzzle solved! Got Star Seal!");
        _player.AddItem(new InventoryItem("Star Seal", "Glowing artifact"));
    }

    private void TakeItem()
    {
        _player.AddItem(new InventoryItem("Clay Tablet", "Ancient writing"));
    }

    private Location GetCurrentLocation() => 
        _map.TryGetValue(_player.Position, out var loc) ? loc : new Location("Unknown", "Endless desert...");
}