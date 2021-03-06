﻿using System;
using System.IO;

namespace TaskWatcher.Common
{
    public static class PathHelper
    {
        public static string ApplicationName { get; set; }

        public static string SettingsFileName { get; set; }

        public static string DefaultRepositoryName { get; set; }

        public static string StatesFileName { get; set; }

        public static string ApplicationFolder
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                    ApplicationName);
            }
        }

        public static string SettingsPath
        {
            get
            {
                return Path.Combine(ApplicationFolder, SettingsFileName);
            }
        }

        public static string StatesPath
        {
            get
            {
                return Path.Combine(ApplicationFolder, StatesFileName);
            }
        }

        static PathHelper()
        {
            ApplicationName = "TaskWatcher";
            SettingsFileName = "config.json";
            DefaultRepositoryName = "default";
            StatesFileName = "states.json";
        }

        public static void InitializeAppFolder()
        {
            if (!Directory.Exists(ApplicationFolder))
            {
                Directory.CreateDirectory(ApplicationFolder);
            }
        }
    }
}
