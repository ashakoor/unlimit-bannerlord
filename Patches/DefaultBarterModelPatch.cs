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

using HarmonyLib;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;

namespace UnlimitLord.Patches
{
    [HarmonyPatch(typeof(DefaultBarterModel), "BarterCooldownWithHeroInDays")]
    internal static class DefaultBarterModelPatch
    {
        public static Settings Setting => Settings.Instance;
        public static bool Enabled => Setting.BarterCooldownEnabled;
        public static int Cooldown => Setting.BarterCooldownDays;

        internal static int Postfix(int result)
        {
            return Cooldown;
        }

        // internal static bool Prepare()
        // {
        //     return Enabled;
        // }
    }
}