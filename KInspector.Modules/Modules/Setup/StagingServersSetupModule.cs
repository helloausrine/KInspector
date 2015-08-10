﻿using System;
using KInspector.Core;

namespace KInspector.Modules.Modules.Setup
{
    public class StagingServersSetupModule : IModule
    {
        public ModuleMetadata GetModuleMetadata()
        {
            return new ModuleMetadata
            {
                Name = "Disable enabled Staging servers",
                Comment = @"Disables Staging servers defined in the Staging application.

The servers are disabled by appending their URL with '.disabled', so that servers disabled by the audit can be identified.
Setting the Enabled state of all servers to false would result in UI not being accessible (which might not be desired).",
                SupportedVersions = new[] { 
                    new Version("8.0"), 
                    new Version("8.1"), 
                    new Version("8.2") 
                },
                Category = "Setup",
            };
        }

        public ModuleResults GetResults(InstanceInfo instanceInfo, DatabaseService dbService)
        {
            var results = dbService.ExecuteAndGetDataSetFromFile("Setup/StagingServerSetupModule.sql");

            return new ModuleResults
            {
                Result = results
            };
        }
    }
}