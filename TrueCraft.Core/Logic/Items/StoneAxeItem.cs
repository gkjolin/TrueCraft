using System;
using TrueCraft.API.Logic;
using TrueCraft.API;

namespace TrueCraft.Core.Logic.Items
{
    public class StoneAxeItem : ToolItem
    {
        public static readonly short ItemID = 0x113;

        public override short ID { get { return 0x113; } }

        public override ToolMaterial Material { get { return ToolMaterial.Stone; } }

        public override string DisplayName { get { return "Stone Axe"; } }
    }
}