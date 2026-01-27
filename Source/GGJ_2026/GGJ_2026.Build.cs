// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GGJ_2026 : ModuleRules
{
	public GGJ_2026(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GGJ_2026",
			"GGJ_2026/Variant_Strategy",
			"GGJ_2026/Variant_Strategy/UI",
			"GGJ_2026/Variant_TwinStick",
			"GGJ_2026/Variant_TwinStick/AI",
			"GGJ_2026/Variant_TwinStick/Gameplay",
			"GGJ_2026/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
