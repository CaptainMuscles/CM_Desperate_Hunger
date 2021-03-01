using RimWorld;
using UnityEngine;
using Verse;

namespace CM_Desperate_Hunger
{
    public class DesperateHungerModSettings : ModSettings
    {
        public bool featureEnabled = true;

        public float minimumMalnutritionToHuntHealthyTarget = 0.2f;

        public bool desperatePredatorsIgnoreSize = true;
        public bool desperatePreyIgnoreSize = true;
        public bool desperatePreyTargetRandomly = false;
        public bool desperateAnimalsIgnoreCombatPower = true;
        public bool desperateHerdAnimalsEatOwnKind = true;

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look(ref featureEnabled, "featureEnabled", true);

            Scribe_Values.Look(ref desperatePredatorsIgnoreSize, "desperatePredatorsIgnoreSize", true);
            Scribe_Values.Look(ref desperatePreyIgnoreSize, "desperatePreyIgnoreSize", true);
            Scribe_Values.Look(ref desperatePreyTargetRandomly, "desperatePreyTargetRandomly", false);
            Scribe_Values.Look(ref desperateAnimalsIgnoreCombatPower, "desperateAnimalsIgnoreCombatPower", true);
            Scribe_Values.Look(ref desperateHerdAnimalsEatOwnKind, "desperateHerdAnimalsEatOwnKind", true);

            Scribe_Values.Look(ref minimumMalnutritionToHuntHealthyTarget, "minimumMalnutritionToHuntHealthyTarget", 0.5f);
        }

        public void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.ColumnWidth = (inRect.width - 34f) / 2f;

            listing_Standard.Begin(inRect);

            listing_Standard.CheckboxLabeled("CM_Desperate_Hunger_Settings_Feature_Enabled_Label".Translate(), ref featureEnabled, "CM_Desperate_Hunger_Settings_Feature_Enabled_Tooltip");

            listing_Standard.CheckboxLabeled("CM_Desperate_Hunger_Settings_Desperate_Predators_Ignore_Size_Label".Translate(), ref desperatePredatorsIgnoreSize, "CM_Desperate_Hunger_Settings_Desperate_Predators_Ignore_Size_Tooltip");
            listing_Standard.CheckboxLabeled("CM_Desperate_Hunger_Settings_Desperate_Prey_Ignore_Size_Label".Translate(), ref desperatePreyIgnoreSize, "CM_Desperate_Hunger_Settings_Desperate_Prey_Ignore_Size_Tooltip");
            listing_Standard.CheckboxLabeled("CM_Desperate_Hunger_Settings_Desperate_Prey_Select_Random_Label".Translate(), ref desperatePreyTargetRandomly, "CM_Desperate_Hunger_Settings_Desperate_Prey_Select_Random_Tooltip");
            listing_Standard.CheckboxLabeled("CM_Desperate_Hunger_Settings_Desperate_Animals_Ignore_Combat_Power_Label".Translate(), ref desperateAnimalsIgnoreCombatPower, "CM_Desperate_Hunger_Settings_Desperate_Animals_Ignore_Combat_Power_Tooltip");
            listing_Standard.CheckboxLabeled("CM_Desperate_Hunger_Settings_Desperate_Herd_Animals_Eat_Own_Kind_Label".Translate(), ref desperateHerdAnimalsEatOwnKind, "CM_Desperate_Hunger_Settings_Desperate_Herd_Animals_Eat_Own_Kind_Tooltip");

            listing_Standard.Label("CM_Desperate_Hunger_Settings_Minimum_Malnutrition_Label".Translate(), -1, "CM_Desperate_Hunger_Settings_Minimum_Malnutrition_Tooltip");
            listing_Standard.Label(minimumMalnutritionToHuntHealthyTarget.ToString("P0"));
            minimumMalnutritionToHuntHealthyTarget = listing_Standard.Slider(minimumMalnutritionToHuntHealthyTarget, 0.0f, 1.0f);

            listing_Standard.End();
        }

        public void UpdateSettings()
        {

        }
    }
}
