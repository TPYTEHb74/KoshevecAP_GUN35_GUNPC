using GamePrototype.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Items.EquipItems
{
    namespace RangedWeapon.Items.EquipItems
    {
        public class RangedWeapon : EquipItem
        {
            public RangedWeapon(UnitFactoryDemo maxDurability, string name, UnitFactoryDemo distance) : base(maxDurability, name)
            {

            }
            public override EquipSlot Slot { get; }
        }
    }   
}
