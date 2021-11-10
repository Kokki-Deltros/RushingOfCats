// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class RushingOfCatsTarget : TargetRules
{
    public RushingOfCatsTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V2;

        ExtraModuleNames.AddRange(new string[] { "RushingOfCats" });
        
        if (Target.Platform == UnrealTargetPlatform.Android)
        {
            ExtraModuleNames.Add("OnlineSubsystemGooglePlay");
            ExtraModuleNames.Add("OnlineSubsystem");
            ExtraModuleNames.Add("AndroidAdvertising");
        }
    }
}
