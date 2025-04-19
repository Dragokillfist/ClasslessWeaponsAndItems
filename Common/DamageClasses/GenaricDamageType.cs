using Terraria;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Common.DamageClasses
{
    public class GenericDamageClass : DamageClass
    {
        // This is an example damage class designed to demonstrate all the current functionality of the feature and explain how to create one of your own.
        // For information about how to apply stat bonuses to specific damage classes, please instead refer to ExampleMod/Content/Items/Accessories/ExampleStatBonusAccessory.
        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            // This method lets you make your damage class benefit from other classes' stat bonuses by default, as well as universal stat bonuses.
            // To briefly summarize the two nonstandard damage class names used by DamageClass:
            // Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
            // There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
            // Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
            if (damageClass == DamageClass.Generic)
                return StatInheritanceData.Full;

            return new StatInheritanceData(
                damageInheritance: 0f,
                critChanceInheritance: 0f,
                attackSpeedInheritance: 0f,
                armorPenInheritance: 0f,
                knockbackInheritance: 0f
            );
        }

        public override bool GetEffectInheritance(DamageClass damageClass)
        {
            if (damageClass == DamageClass.Melee)
                return true;
            if (damageClass == DamageClass.Magic)
                return true;
            
            return false;
        }

        public override void SetDefaultStats(Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.20f; // 20% damage increase
            player.GetCritChance<GenericDamageClass>() += 5; // 5% crit chance increase
        }
        public override bool UseStandardCritCalcs => true; // Use standard crit calculations for this damage type.

        public override bool ShowStatTooltipLine(Player player, string lineName)
        {
            if (lineName == "Damage")
            {
                return true; // Show the damage tooltip line for this damage type.
            }
            return base.ShowStatTooltipLine(player, lineName); // Use the default behavior for other tooltip lines.
        }
    }
}