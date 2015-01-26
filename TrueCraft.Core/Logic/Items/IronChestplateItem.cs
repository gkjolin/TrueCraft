using System;
using TrueCraft.API.Logic;
using TrueCraft.API;

namespace TrueCraft.Core.Logic.Items
{
    public class IronChestplateItem : ArmourItem
    {
        public static readonly short ItemID = 0x133;

        public override short ID { get { return 0x133; } }

        public override ArmourMaterial Material { get { return ArmourMaterial.Iron; } }

        public override string DisplayName { get { return "Iron Chestplate"; } }
    }
}