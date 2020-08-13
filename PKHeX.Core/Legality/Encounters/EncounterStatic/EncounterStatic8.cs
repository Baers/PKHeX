﻿namespace PKHeX.Core
{
    public class EncounterStatic8 : EncounterStatic
    {
        protected override bool IsMatchLevel(PKM pkm, DexLevel evo)
        {
            var met = pkm.Met_Level;
            if (met == Level)
                return true;
            if (EncounterArea8.IsWildArea8(Location) || EncounterArea8.IsWildArea8Armor(Location))
                return met == 60;
            return false;
        }
    }
}