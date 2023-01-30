﻿using Dalamud.Configuration;
using EurekaHelper.System;
using System;

namespace EurekaHelper
{
    public enum PayloadOptions
    {
        ShoutToChat,
        CopyToClipboard
    }

    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;

        public void Initialize() { }

        public bool DisplayFateProgress = false;

        public bool DisplayBunnyFates = false;

        public bool DisplayFatePop = true;

        public bool PlayPopSound = true;

        public bool CopyNMToClipboard = true;

        public bool AutoPopFate = true;

        public SoundManager.SoundEffect NMSoundEffect { get; set; } = SoundManager.SoundEffect.SoundEffect36;

        public SoundManager.SoundEffect BunnySoundEffect { get; set; } = SoundManager.SoundEffect.SoundEffect41;

        public PayloadOptions PayloadOptions { get; set; } = PayloadOptions.ShoutToChat;

        public void Save() => DalamudApi.PluginInterface.SavePluginConfig(this);
    }
}
