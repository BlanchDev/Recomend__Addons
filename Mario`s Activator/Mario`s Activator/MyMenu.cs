using System;
using System.Collections.Generic;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using Mario_s_Lib;
using Mario_s_Lib.DataBases;
using static Mario_s_Activator.SummonerSpells;

namespace Mario_s_Activator
{
    internal class MyMenu
    {
        public static Menu FirstMenu = MainMenu.AddMenu("Mario`s Activator", "marioactivatorr");
        public static Menu OffensiveMenu = FirstMenu.AddSubMenu("• Offensive Items", "activatorOffensive");
        public static Menu DefensiveMenu = FirstMenu.AddSubMenu("• Defensive Items", "activatordefensive");
        public static Menu CleansersMenu = FirstMenu.AddSubMenu("• Cleansers", "activatorcleansers");
        public static Menu ConsumablesMenu = FirstMenu.AddSubMenu("• Consumables", "activatorconsumables");
        public static Menu ProtectMenu = FirstMenu.AddSubMenu("• Protector", "activatorprotector");
        public static Menu SummonerMenu = FirstMenu.AddSubMenu("• Summoner Spells", "activatorSummonerspells");
        public static Menu MiscMenu = FirstMenu.AddSubMenu("• Misc", "activatormisc");
        public static Menu DrawingMenu = FirstMenu.AddSubMenu("• Drawing", "activatordrawing");
        public static Menu SettingsMenu = FirstMenu.AddSubMenu("• Settings", "activatorsettings");

        public static void InitializeMenu()
        {
            FirstMenu.AddGroupLabel("This addon is made by MarioGK and should not be redistributed in any way.");
            FirstMenu.AddGroupLabel("Any unauthorized redistribution without credits will result in severe consequences.");
            FirstMenu.AddGroupLabel("I hope you have fun using it and please give me feedbacks");

            #region OffensiveMenu

            OffensiveMenu.AddGroupLabel("Bilgewater Cutlass");
            OffensiveMenu.CreateCheckBox("Use Bilgewater Cutlass.", "check3144");
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider3144", 90);
            OffensiveMenu.AddGroupLabel("Blade of the ruined kings");
            OffensiveMenu.CreateCheckBox("Use Blade of the ruined king.", "check3153");
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider3153", 60);
            OffensiveMenu.AddGroupLabel("Tiamat");
            OffensiveMenu.CreateCheckBox("Use tiamat.", "check3077");
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider3077", 90);
            OffensiveMenu.AddGroupLabel("Hydra");
            OffensiveMenu.CreateCheckBox("Use hydra.", "check3074");
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider3074", 90);
            OffensiveMenu.AddGroupLabel("Titanic Hydra");
            OffensiveMenu.CreateCheckBox("Use titanic hydra.", "check"+ (int)ItemId.Titanic_Hydra);
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider" + (int)ItemId.Titanic_Hydra, 90);
            OffensiveMenu.AddGroupLabel("Youmuus");
            OffensiveMenu.CreateCheckBox("Use youmuus.", "check3142");
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider3142", 70);
            OffensiveMenu.AddGroupLabel("Hextech GunBlade");
            OffensiveMenu.CreateCheckBox("Use Hextech GunBlade.", "check3146");
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider3146", 40);
            OffensiveMenu.AddGroupLabel("Frost Queens Claim");
            OffensiveMenu.CreateCheckBox("Use frost queen.", "check3092");
            OffensiveMenu.CreateSlider("Use it if the ENEMY health is lower than ({0}%).", "slider3092", 40);

            #endregion OffensiveMenu

            #region DefensiveMenu

            DefensiveMenu.AddGroupLabel("Zhonyas");
            DefensiveMenu.CreateCheckBox("Use Zhonyas.", "check" + (int)ItemId.Zhonyas_Hourglass);
            DefensiveMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + (int)ItemId.Zhonyas_Hourglass, 25);
            DefensiveMenu.AddGroupLabel("Seraph");
            DefensiveMenu.CreateCheckBox("Use Seraph.", "check" + (int)ItemId.Seraphs_Embrace);
            DefensiveMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + (int)ItemId.Seraphs_Embrace, 25);
            DefensiveMenu.AddGroupLabel("Face Of The Mountain");
            DefensiveMenu.CreateCheckBox("Use Face Of The Mountain.", "check" + "3401");
            DefensiveMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + "3401", 10);
            DefensiveMenu.CreateSlider("Use it if ALLY health is lower than ({0}%).", "slider" + "3401" + "ally", 20);
            DefensiveMenu.AddGroupLabel("Talisman");
            DefensiveMenu.CreateCheckBox("Use Talisman.", "check" + "3069");
            DefensiveMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + "3069", 20);
            DefensiveMenu.AddGroupLabel("Solari");
            DefensiveMenu.CreateCheckBox("Use Solari.", "check" + "3190");
            DefensiveMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + "3190", 20);
            DefensiveMenu.AddGroupLabel("Randuins");
            DefensiveMenu.CreateCheckBox("Use Randuins.", "check" + "3143");
            DefensiveMenu.CreateSlider("Use it if there are ({0}) in range.", "slider" + "3143", 2, 0, 5);
            DefensiveMenu.AddGroupLabel("Ohmwrecker");
            DefensiveMenu.CreateCheckBox("Use Ohmwrecker.", "check" + "3056");
            DefensiveMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + "3056", 60);

            #endregion DefensiveMenu

            #region CleansersMenu
            CleansersMenu.AddGroupLabel("Cleanse settings");
            CleansersMenu.CreateSlider("Delay to use the cleanse item", "delayCleanse", 50, 0, 500);
            CleansersMenu.AddGroupLabel("What CC`s to use the items/spell ?");
            CleansersMenu.CreateCheckBox("Stun", "ccStun");
            CleansersMenu.CreateCheckBox("Blind", "ccBlind", false);
            CleansersMenu.CreateCheckBox("Slow", "ccSlow", false);
            CleansersMenu.CreateCheckBox("Snare", "ccSnare");
            CleansersMenu.CreateCheckBox("Flee", "ccFlee");
            CleansersMenu.CreateCheckBox("Supression", "ccSupression");
            CleansersMenu.CreateCheckBox("Taunt", "ccTaunt");
            CleansersMenu.CreateCheckBox("Charm", "ccCharm");
            CleansersMenu.CreateCheckBox("Polymorph", "ccPolymorph");
            CleansersMenu.CreateCheckBox("Duskblade of Draktharr", "ccDusk");
            CleansersMenu.AddLabel("Special spells to use cleanse");
            CleansersMenu.CreateCheckBox("Zed R", "ccZedR");
            CleansersMenu.CreateCheckBox("Vladmir R", "ccVladmirR");
            CleansersMenu.CreateCheckBox("Mordekaiser R", "ccMordekaiserR");
            CleansersMenu.CreateCheckBox("Trundle R", "ccTrundleR");
            CleansersMenu.CreateCheckBox("Fiora R", "ccFioraR");
            CleansersMenu.CreateCheckBox("Kalista E", "ccKalistaE");
            CleansersMenu.AddGroupLabel("Items");
            CleansersMenu.CreateCheckBox("Use Dervish Blade.", "check" + "3137");
            CleansersMenu.CreateCheckBox("Use Mercurial Scimitar.", "check" + "3139");
            CleansersMenu.CreateCheckBox("Use QuickSilver.", "check" + "3140");
            if (PlayerHasCleanse)
            {
                CleansersMenu.AddLabel("Cleanse Summoner Spell");
                CleansersMenu.CreateCheckBox("Use cleanse", "check" + "cleanse");
            }
            CleansersMenu.AddGroupLabel("Mikael Settings");
            CleansersMenu.CreateCheckBox("Use Mikael.", "check" + "3222");
            CleansersMenu.AddSeparator();
            foreach (var ally in EntityManager.Heroes.Allies.Where(a => !a.IsMe))
            {
                CleansersMenu.CreateCheckBox("Use on "+ ally.ChampionName + "("+ally.Name+")", "check" + ally.ChampionName);
            }

            #endregion CleansersMenu

            #region ConsumableMenu
            ConsumablesMenu.AddGroupLabel("Health Potion");
            ConsumablesMenu.CreateCheckBox("Use Health Potion.", "check" + "2003");
            ConsumablesMenu.CreateSlider("Use it if MY HEALTH is lower than ({0}%).", "slider" + "2003" + "health", 45);
            ConsumablesMenu.AddGroupLabel("Biscuit");
            ConsumablesMenu.CreateCheckBox("Use Biscuit.", "check" + (int)ItemId.Total_Biscuit_of_Rejuvenation);
            ConsumablesMenu.CreateSlider("Use it if MY HEALTH is lower than ({0}%).", "slider" + (int)ItemId.Total_Biscuit_of_Rejuvenation + "health", 45);
            ConsumablesMenu.CreateSlider("Use it if MY MANA is lower than ({0}%).", "slider" + (int)ItemId.Total_Biscuit_of_Rejuvenation + "mana", 30);
            ConsumablesMenu.AddGroupLabel("Hunter`s Potion");
            ConsumablesMenu.CreateCheckBox("Use Hunter`s Potion.", "check" + "2032");
            ConsumablesMenu.CreateSlider("Use it if MY HEALTH is lower than ({0}%).", "slider" + "2032" + "health", 30);
            ConsumablesMenu.CreateSlider("Use it if MY MANA is lower than ({0}%).", "slider" + "2032" + "mana", 30);
            ConsumablesMenu.CreateCheckBox("Use Corrupting Potion.", "check" + (int)ItemId.Corrupting_Potion);
            ConsumablesMenu.CreateSlider("Use it if MY HEALTH is lower than ({0}%).", "slider" + (int)ItemId.Corrupting_Potion + "health", 30);
            ConsumablesMenu.CreateSlider("Use it if MY MANA is lower than ({0}%).", "slider" + (int)ItemId.Corrupting_Potion + "mana", 30);
            ConsumablesMenu.CreateCheckBox("Use Refillable Potion.", "check" + (int)ItemId.Refillable_Potion);
            ConsumablesMenu.CreateSlider("Use it if MY HEALTH is lower than ({0}%).", "slider" + (int)ItemId.Refillable_Potion + "health", 30);
            ConsumablesMenu.AddGroupLabel("Elixirs");
            ConsumablesMenu.CreateCheckBox("Use Elixir Of Sorcery", "check" + (int) ItemId.Elixir_of_Sorcery);
            ConsumablesMenu.CreateCheckBox("Use Elixir Of Wrath", "check" + (int) ItemId.Elixir_of_Wrath);
            ConsumablesMenu.CreateCheckBox("Use Elixir Of Iron", "check" + (int) ItemId.Elixir_of_Iron);
            #endregion ConsumablesMenu

            #region ProtectMenu
            var champS = ProtectSpells.Spells.FirstOrDefault(s => s.Champ == Player.Instance.Hero);
            if (champS != null)
            {
                ProtectMenu.AddGroupLabel("Settings: ");
                ProtectMenu.CreateCheckBox("Enable protector", "checkProtector");
                ProtectMenu.CreateSlider("Ally health must be lower than {0}", "protectallyhealth", 20);
                ProtectMenu.AddGroupLabel("Spells: ");

                var spell = Player.GetSpell(champS.Slot);
                
                if (spell != null)
                {
                    var slot = spell.Slot.ToString()[spell.Slot.ToString().Length - 1];
                    ProtectMenu.CreateCheckBox("- Use spell " + slot, "canUseSpell" + spell.Slot);
                }

                ProtectMenu.AddGroupLabel("WhiteList: ");
                foreach (var a in EntityManager.Heroes.Allies)
                {
                    ProtectMenu.CreateCheckBox("- Can use on " + a.ChampionName + " (" + a.Name + ") ", "canUseSpellOn" + a.ChampionName);
                }
            }
            else
            {
                ProtectMenu.AddGroupLabel("You dont have a spell to protect your allies");
            }

            #endregion ProtectMenu

            #region SummonerSpells

            if (PlayerHasSmite)
            {
                SummonerMenu.AddGroupLabel("Smite");
                SummonerMenu.CreateKeyBind("Disable Smite", "smiteKeybind", 'Z', 'U');
                SummonerMenu.CreateCheckBox("Draw smite range.", "drawSmiteRange");
                SummonerMenu.CreateCheckBox("Draw smite damage on jungle minions HP.", "drawSmiteDamage");
                
                var combo = SummonerMenu.Add("comboBox", new ComboBox("Smite mode", new List<string> {"Use Prediction", " Dont use prediction"}));
                var label = SummonerMenu.Add("comboBoxText", new Label("aaa"));
                switch (combo.CurrentValue)
                {
                    case 0:
                        label.CurrentValue = "It will try to predict the health of the jungle minion to have a fast Smite";
                        break;
                    case 1:
                        label.CurrentValue = "It will only use if the jungle minion health is lower than the smite damage";
                        break;
                }
                combo.OnValueChange += delegate (ValueBase<int> sender, ValueBase<int>.ValueChangeArgs args)
                {
                    switch (sender.CurrentValue)
                    {
                        case 0:
                            label.CurrentValue = "It will try to predict the health of the jungle minion to have a fast Smite";
                            break;
                        case 1:
                            label.CurrentValue = "It will only use if the jungle minion health is lower than the smite damage";
                            break;
                    }
                };
                SummonerMenu.AddSeparator();
                SummonerMenu.CreateSlider("Subtract [{0}] to the smite damage calculation", "sliderDMGSmite", 15, 0, 50);
                SummonerMenu.AddSeparator();
                SummonerMenu.CreateCheckBox("Use smite on champions", "smiteUseOnChampions");
                SummonerMenu.CreateSlider("Keep how many smites", "smiteKeep", 1, 0, 2);

                switch (Game.MapId)
                {
                    case GameMapId.TwistedTreeline:
                        SummonerMenu.AddLabel("Epic");
                        SummonerMenu.CreateCheckBox("Smite Spider Boss", "monster" + "TT_Spiderboss");
                        SummonerMenu.AddLabel("Normal");
                        SummonerMenu.CreateCheckBox("Smite Golem", "monster" + "TTNGolem");
                        SummonerMenu.CreateCheckBox("Smite Wolf", "monster" + "TTNWolf");
                        SummonerMenu.CreateCheckBox("Smite Wraith", "monster" + "TTNWraith", false);
                        break;
                    case GameMapId.SummonersRift:
                        SummonerMenu.AddLabel("Epic");
                        SummonerMenu.CreateCheckBox("Smite Baron", "monster" + "SRU_Baron");
                        SummonerMenu.CreateCheckBox("Smite Dragon", "monster" + "SRU_Dragon");
                        SummonerMenu.CreateCheckBox("Smite RiftHearald", "monster" + "SRU_RiftHerald");
                        SummonerMenu.AddLabel("Normal");
                        SummonerMenu.CreateCheckBox("Smite Blue", "monster" + "SRU_Blue");
                        SummonerMenu.CreateCheckBox("Smite Red", "monster" + "SRU_Red");
                        SummonerMenu.CreateCheckBox("Smite Crab", "monster" + "Sru_Crab", false);
                        SummonerMenu.AddLabel("Meh...");
                        SummonerMenu.CreateCheckBox("Smite Gromp", "monster" + "SRU_Gromp", false);
                        SummonerMenu.CreateCheckBox("Smite Murkwolf", "monster" + "SRU_Murkwolf", false);
                        SummonerMenu.CreateCheckBox("Smite Razorbeak", "monster" + "SRU_Razorbeak", false);
                        SummonerMenu.CreateCheckBox("Smite Krug", "monster" + "SRU_Krug", false);
                        break;
                }
            }

            if (PlayerHasBarrier)
            {
                SummonerMenu.AddGroupLabel("Barrier");
                SummonerMenu.CreateCheckBox("Use Barrier.", "check" + "barrier");
                SummonerMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + "barrier", 20);
            }

            if (PlayerHasHeal)
            {
                SummonerMenu.AddGroupLabel("Heal");
                SummonerMenu.CreateCheckBox("Use Heal.", "check" + "heal");
                SummonerMenu.CreateSlider("Use it if MY health is lower than ({0}%).", "slider" + "heal" + "me", 20);
                SummonerMenu.CreateSlider("Use it if ALLY health is lower than ({0}%).", "slider" + "heal" + "ally", 10);
            }

            if (PlayerHasIgnite)
            {
                SummonerMenu.AddGroupLabel("Ignite");
                SummonerMenu.CreateCheckBox("Use ignite.", "check" + "ignite");
                SummonerMenu.AddLabel("Advanced Options please dont modify them if you dont know what they do");
                SummonerMenu.CreateSlider("Minimun range to cast ignite on target", "minimunRangeIgnite", 480, 0, 600);
            }

            if (PlayerHasPoroThrower)
            {
                SummonerMenu.AddGroupLabel("Snow Ball");
                SummonerMenu.CreateCheckBox("Use Snow Ball.", "check" + "snowball");
            }

            if (PlayerHasCleanse)
            {
                SummonerMenu.AddGroupLabel("The activator detected that you have cleanse please go to the cleansers menu to configurate it");
            }

            #endregion SummonerSpells

            #region Misc
            MiscMenu.AddGroupLabel("Revealers");
            MiscMenu.AddLabel("Trinkets");
            MiscMenu.CreateCheckBox("Use trinket to reveal invisible enemies", "revelInviEnemiesTrinket");
            MiscMenu.CreateCheckBox("Use trinket to reveal a bush if an enemy enters it ", "revelBushEnemiesTrinket");
            MiscMenu.AddLabel("Wards");
            MiscMenu.CreateCheckBox("Use ward to reveal invisible enemies", "revelInviEnemiesWard");
            MiscMenu.CreateCheckBox("Use trinket to reveal a bush if an enemy enters it ", "revelBushEnemiesWard");
            #endregion Misc

            #region Drawings

            DrawingMenu.AddGroupLabel("All drawings settings");
            DrawingMenu.CreateCheckBox("Disable all drawings", "disableDrawings", false);

            DrawingMenu.AddGroupLabel("Offensive Items");
            DrawingMenu.CreateCheckBox("Bilgewater Cutlass", "draw" + (int)ItemId.Bilgewater_Cutlass);
            DrawingMenu.CreateCheckBox("Blade of the ruined king", "draw" + (int)ItemId.Blade_of_the_Ruined_King);
            DrawingMenu.CreateCheckBox("Tiamat", "draw" + (int)ItemId.Tiamat);
            DrawingMenu.CreateCheckBox("Ravenous Hydra", "draw" + (int)ItemId.Ravenous_Hydra);
            DrawingMenu.CreateCheckBox("Titanic Hydra", "draw" + (int)ItemId.Titanic_Hydra);
            DrawingMenu.CreateCheckBox("Youmuus GhostBlade", "draw" + (int)ItemId.Youmuus_Ghostblade);
            DrawingMenu.CreateCheckBox("Hextech GunBlade", "draw" + (int)ItemId.Hextech_Gunblade);

            DrawingMenu.AddGroupLabel("Defensive Items");
            DrawingMenu.CreateCheckBox("Face of the mountain", "draw" + (int)ItemId.Face_of_the_Mountain);
            DrawingMenu.CreateCheckBox("Locket Of the Iron Solari", "draw" + (int)ItemId.Locket_of_the_Iron_Solari);
            DrawingMenu.CreateCheckBox("Randuins", "draw" + (int)ItemId.Randuins_Omen);
            DrawingMenu.CreateCheckBox("Ohmwrecker", "draw" + (int)ItemId.Ohmwrecker);

            #endregion Drawings

            #region Settings
            SettingsMenu.AddGroupLabel("Danger Options");
            SettingsMenu.AddLabel("Please go to the Mario`s Lib menu and configure the danger settings there");
            SettingsMenu.AddGroupLabel("Offensive items options");
            SettingsMenu.CreateCheckBox("Use offensive items only in combo", "comboUseItems");
            SettingsMenu.AddGroupLabel("Improve FPS");
            SettingsMenu.AddLabel("The higher the slider below is, the more fps you will get and the slower the tick will be");
            SettingsMenu.CreateSlider("Tick Limiter", "tickLimiter", 0, 0, 1000);
            SettingsMenu.AddSeparator();
            SettingsMenu.AddGroupLabel("Debug Settings");
            SettingsMenu.CreateCheckBox("Enable developer debugging.", "dev", false);

            #endregion Settings

            FirstMenu.InitiliazeDangerHandler();
        }
    }
}
