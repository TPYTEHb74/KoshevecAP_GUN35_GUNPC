using GamePrototype.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Items.EquipItems
{
    public class Helm : EquipItem
    {
        public Helm(uint maxDurability, string name) : base(maxDurability, name)
        {

        }
        public override EquipSlot Slot { get; }
    }
}
