﻿using BabyStepsMultiplayerClient.Config;
using MelonLoader;

namespace BabyStepsMultiplayerClient
{
    public static class ModSettings
    {
        public static readonly ConnectionConfig connection = new();
        public static readonly PlayerConfig player = new();

        public static void Load()
        {
            connection.Load();
            player.Load();
        }

        public static void Save()
        {
            connection.Save();
            player.Save();
        }
    }
}
