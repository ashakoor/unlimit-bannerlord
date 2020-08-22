﻿/*
 Copyright (C) 2020 ashakoor

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License,
 or any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using TaleWorlds.CampaignSystem;

namespace UnlimitLord
{
    public class PatchAppliesTo
    {
        public static bool DoesPatchApply(AppliesToEnum @enum, CharacterObject character)
        {
            switch (@enum)
            {
                case AppliesToEnum.PlayerOnly:
                    return character.IsThisCharacterPlayerCharacter();

                case AppliesToEnum.PlayerCompanions:
                    return character.IsThisCharacterPlayerCompanion() || character.IsThisCharacterPlayerCharacter();

                case AppliesToEnum.PlayerParty:
                    goto default;

                case AppliesToEnum.PlayerClan:
                    return character.IsThisCharacterInPlayerClan();

                case AppliesToEnum.PlayerArmy:
                    return character.IsThisCharacterInPlayerArmy();

                case AppliesToEnum.PlayerKingdom:
                    return character.IsThisCharacterInPlayerKingdom() || character.IsThisCharacterInPlayerClan();

                case AppliesToEnum.Everyone:
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(@enum), @enum, null);
            }
        }

        public static bool DoesPatchApply(AppliesToEnum @enum, Hero hero)
        {
            switch (@enum)
            {
                case AppliesToEnum.PlayerOnly:
                    return hero.IsThisHeroPlayerHero();

                case AppliesToEnum.PlayerCompanions:
                    return hero.IsThisHeroPlayerCompanion() || hero.IsThisHeroPlayerHero();

                case AppliesToEnum.PlayerParty:
                    goto default;

                case AppliesToEnum.PlayerClan:
                    return hero.IsThisHeroInPlayerClan();

                case AppliesToEnum.PlayerArmy:
                    return hero.IsThisHeroInPlayerArmy();

                case AppliesToEnum.PlayerKingdom:
                    return hero.IsThisHeroInPlayerKingdom() || hero.IsThisHeroInPlayerClan();

                case AppliesToEnum.Everyone:
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(@enum), @enum, null);
            }
        }

        public static bool DoesPatchApply(AppliesToEnum @enum, MobileParty party)
        {
            switch (@enum)
            {
                case AppliesToEnum.PlayerOnly:
                    goto default;
                case AppliesToEnum.PlayerCompanions:
                    goto default;
                case AppliesToEnum.PlayerParty:
                    return party.IsPlayerLeadingThisParty();

                case AppliesToEnum.PlayerClan:
                    return party.IsThisPartyInPlayerClan();

                case AppliesToEnum.PlayerArmy:
                    return party.IsThisPartyInPlayerArmy() || party.IsPlayerLeadingThisParty();

                case AppliesToEnum.PlayerKingdom:
                    return party.IsThisPartyInPlayerKingdom() || party.IsThisPartyInPlayerClan();

                case AppliesToEnum.Everyone:
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(@enum), @enum, null);
            }
        }

        public static bool DoesPatchApply(AppliesToEnum @enum, PartyBase party)
        {
            switch (@enum)
            {
                case AppliesToEnum.PlayerOnly:
                    goto default;
                case AppliesToEnum.PlayerCompanions:
                    goto default;
                case AppliesToEnum.PlayerParty:
                    return party.IsPlayerLeadingThisParty();

                case AppliesToEnum.PlayerClan:
                    return party.IsThisPartyInPlayerClan();

                case AppliesToEnum.PlayerArmy:
                    return party.IsThisPartyInPlayerArmy() || party.IsPlayerLeadingThisParty();

                case AppliesToEnum.PlayerKingdom:
                    return party.IsThisPartyInPlayerKingdom() || party.IsThisPartyInPlayerClan();

                case AppliesToEnum.Everyone:
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(@enum), @enum, null);
            }
        }

        public static bool DoesPatchApply(AppliesToEnum @enum, Clan clan)
        {
            switch (@enum)
            {
                case AppliesToEnum.PlayerOnly:
                    goto default;
                case AppliesToEnum.PlayerCompanions:
                    goto default;
                case AppliesToEnum.PlayerParty:
                    goto default;
                case AppliesToEnum.PlayerClan:
                    return clan.IsPlayerLeadingThisClan();

                case AppliesToEnum.PlayerArmy:
                    goto default;
                case AppliesToEnum.PlayerKingdom:
                    return clan.IsThisClanInPlayerKingdom() || clan.IsPlayerLeadingThisClan();

                case AppliesToEnum.Everyone:
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(@enum), @enum, null);
            }
        }

        public static bool DoesPatchApply(AppliesToEnum @enum, Army army)
        {
            switch (@enum)
            {
                case AppliesToEnum.PlayerOnly:
                    goto default;
                case AppliesToEnum.PlayerCompanions:
                    goto default;
                case AppliesToEnum.PlayerParty:
                    goto default;
                case AppliesToEnum.PlayerClan:
                    goto default;
                case AppliesToEnum.PlayerArmy:
                    return army.IsPlayerInThisArmy();

                case AppliesToEnum.PlayerKingdom:
                    return army.IsThisArmyInPlayerKingdom();

                case AppliesToEnum.Everyone:
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(@enum), @enum, null);
            }
        }

        public static bool DoesPatchApply(AppliesToEnum @enum, Kingdom kingdom)
        {
            switch (@enum)
            {
                case AppliesToEnum.PlayerOnly:
                    goto default;
                case AppliesToEnum.PlayerCompanions:
                    goto default;
                case AppliesToEnum.PlayerParty:
                    goto default;
                case AppliesToEnum.PlayerClan:
                    goto default;
                case AppliesToEnum.PlayerArmy:
                    goto default;
                case AppliesToEnum.PlayerKingdom:
                    return kingdom.IsPlayerInThisKingdom();

                case AppliesToEnum.Everyone:
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(@enum), @enum, null);
            }
        }
    }

    public enum AppliesToEnum : byte
    {
        PlayerOnly,
        PlayerCompanions,
        PlayerParty,
        PlayerClan,
        PlayerArmy,
        PlayerKingdom,
        Everyone
    }
}