using Classes;

public class Dungeon
{
    private Room[] _rooms;

    public Dungeon()
    {
        _rooms = new Room[3];
        {
            new Room(new Unit("Warrior"), new Weapon(5, 15)),
            new Room(new Unit("Mage"), new Weapon(1, 10)),
            new Room(new Unit("Rogue"), new Weapon(3, 12))           
         }
    }

    public void ShowRooms()
    {
        for (int i = 0; i < _rooms.Length; i++)
        {
            var room = _rooms[i];
            Console.WriteLine($"Unit of room: {room.Unit}");
            Console.WriteLine($"Weapon of room: {room.Weapon}");
            Console.WriteLine("—");
        }
    }
}