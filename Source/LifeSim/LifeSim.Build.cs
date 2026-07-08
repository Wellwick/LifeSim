// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LifeSim : ModuleRules
{
	public LifeSim(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"LifeSim",
			"LifeSim/Variant_Platforming",
			"LifeSim/Variant_Platforming/Animation",
			"LifeSim/Variant_Combat",
			"LifeSim/Variant_Combat/AI",
			"LifeSim/Variant_Combat/Animation",
			"LifeSim/Variant_Combat/Gameplay",
			"LifeSim/Variant_Combat/Interfaces",
			"LifeSim/Variant_Combat/UI",
			"LifeSim/Variant_SideScrolling",
			"LifeSim/Variant_SideScrolling/AI",
			"LifeSim/Variant_SideScrolling/Gameplay",
			"LifeSim/Variant_SideScrolling/Interfaces",
			"LifeSim/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
