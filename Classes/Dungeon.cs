public class Dungeon
{
    private List<string> rooms;

    public Dungeon()
    {
        rooms = new List<string> { "Room1", "Room2", "Room3" };
    }

    public void ShowRooms()
    {
        foreach (var room in rooms)
        {
            Console.WriteLine(room);
        }
    }
}