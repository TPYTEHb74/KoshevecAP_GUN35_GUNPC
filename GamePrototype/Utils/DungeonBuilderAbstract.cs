using GamePrototype.Dungeon;
using GamePrototype.Items.EconomicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamePrototype.Utils.UnitFactoryDemoAbstract;

namespace GamePrototype.Utils
{
    public abstract class DungeonBuilderAbstract
    {
        protected UnitFactoryDemoAbstract UnitFactory;
        public abstract DungeonRoom BuildDungeon();
    }

    public class DungeonBuilderEasy : DungeonBuilderAbstract
    {
        public DungeonBuilderEasy()
        {
            UnitFactory = new UnitFactoryDemoEasy();
        }
        public override DungeonRoom BuildDungeon()
        {
            var enter = new DungeonRoom("Enter");
            var monsterRoom = new DungeonRoom("Monster", UnitFactoryDemo.CreateGoblinEnemy());
            var emptyRoom = new DungeonRoom("Empty");
            var lootRoom = new DungeonRoom("Loot1", new Gold());
            var lootStoneRoom = new DungeonRoom("Loot1", new Grindstone("Stone"));
            var finalRoom = new DungeonRoom("Final", new Grindstone("Stone1"));

            enter.TrySetDirection(Direction.Right, monsterRoom);
            enter.TrySetDirection(Direction.Left, lootRoom);

            monsterRoom.TrySetDirection(Direction.Forward, emptyRoom);
            monsterRoom.TrySetDirection(Direction.Right, lootStoneRoom);

            lootRoom.TrySetDirection(Direction.Forward, lootStoneRoom);
            lootRoom.TrySetDirection(Direction.Left, lootStoneRoom);
            lootRoom.TrySetDirection(Direction.Right, finalRoom);

            lootRoom.TrySetDirection(Direction.Forward, finalRoom);
            lootStoneRoom.TrySetDirection(Direction.Forward, finalRoom);
            emptyRoom.TrySetDirection(Direction.Forward, finalRoom);

            return enter;

        }
    }

    public class DungeonBuilderMedium : DungeonBuilderAbstract
    {
        public DungeonBuilderMedium()
        {
            UnitFactory = new UnitFactoryDemoMedium();
        }
        public override DungeonRoom BuildDungeon()
        {
            var enter = new DungeonRoom("Enter");
            var monsterRoom = new DungeonRoom("Monster", UnitFactoryDemo.CreateGoblinEnemy());
            var emptyRoom = new DungeonRoom("Empty");
            var lootRoom = new DungeonRoom("Loot1", new Gold());
            var lootStoneRoom = new DungeonRoom("Loot1", new Grindstone("Stone"));
            var finalRoom = new DungeonRoom("Final", new Grindstone("Stone1"));

            enter.TrySetDirection(Direction.Right, emptyRoom);
            enter.TrySetDirection(Direction.Left, monsterRoom);
            enter.TrySetDirection(Direction.Forward, lootRoom);

            monsterRoom.TrySetDirection(Direction.Forward, lootRoom);
            monsterRoom.TrySetDirection(Direction.Right, lootStoneRoom);
            monsterRoom.TrySetDirection(Direction.Left, emptyRoom);

            lootRoom.TrySetDirection(Direction.Forward, lootRoom);
            lootRoom.TrySetDirection(Direction.Left, emptyRoom);
            lootRoom.TrySetDirection(Direction.Right, monsterRoom);

            monsterRoom.TrySetDirection(Direction.Forward, finalRoom);
            lootStoneRoom.TrySetDirection(Direction.Forward, finalRoom);
            emptyRoom.TrySetDirection(Direction.Forward, finalRoom);
            return enter;

        }
    }

    public class DungeonBuilderHard : DungeonBuilderAbstract
    {
        public DungeonBuilderHard()
        {
            UnitFactory = new UnitFactoryDemoHard();
        }
        public override DungeonRoom BuildDungeon()
        {
            var enter = new DungeonRoom("Enter");
            var monsterRoom = new DungeonRoom("Monster", UnitFactoryDemo.CreateGoblinEnemy());
            var emptyRoom = new DungeonRoom("Empty");
            var lootRoom = new DungeonRoom("Loot1", new Gold());
            var lootStoneRoom = new DungeonRoom("Loot1", new Grindstone("Stone"));
            var finalRoom = new DungeonRoom("Final", new Grindstone("Stone1"));

            enter.TrySetDirection(Direction.Right, lootStoneRoom);
            enter.TrySetDirection(Direction.Left, lootRoom);

            lootRoom.TrySetDirection(Direction.Forward, monsterRoom);
            lootRoom.TrySetDirection(Direction.Right, emptyRoom);

            monsterRoom.TrySetDirection(Direction.Forward, emptyRoom);
            monsterRoom.TrySetDirection(Direction.Left, lootRoom);
            monsterRoom.TrySetDirection(Direction.Right, lootStoneRoom);

            lootStoneRoom.TrySetDirection(Direction.Forward, emptyRoom);
            lootStoneRoom.TrySetDirection(Direction.Left, monsterRoom);
            lootStoneRoom.TrySetDirection(Direction.Right, finalRoom);

            emptyRoom.TrySetDirection(Direction.Forward, finalRoom);
            emptyRoom.TrySetDirection(Direction.Left, monsterRoom);
            emptyRoom.TrySetDirection(Direction.Right, lootRoom);

            monsterRoom.TrySetDirection(Direction.Forward, finalRoom);
            lootRoom.TrySetDirection(Direction.Forward, finalRoom);
            return enter;

        }
    }
}