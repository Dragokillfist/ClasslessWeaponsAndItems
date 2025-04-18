using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace ClasslessWeaponsAndItems.Core.ItemDropRules.DropConditions

{
	// Very simple drop condition: drop during daytime
	public class SlimeKingFist : IItemDropRuleCondition
	{
		private static LocalizedText Description;

		public SlimeKingFist() {
			Description ??= Language.GetOrRegister("Mods.ClasslessWeaponsAndItems.DropConditions.SlimeKingFist");
		}

		public bool CanDrop(DropAttemptInfo info) {
			return Main.expertMode && NPC.downedSlimeKing;
		}

		public bool CanShowItemDropInUI() {
			return true;
		}

		public string GetConditionDescription() {
			return Description.Value;
		}
	}
}