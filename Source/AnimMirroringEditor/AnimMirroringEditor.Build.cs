using UnrealBuildTool;

public class AnimMirroringEditor : ModuleRules
{
    public AnimMirroringEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        
        PublicIncludePaths.AddRange(
            new string[] {
                "AnimMirroringEditor/Public"
                // ... add public include paths required here ...
            }
            );
                
        
        PrivateIncludePaths.AddRange(
            new string[] {
                "AnimMirroringEditor/Private",
                // ... add other private include paths required here ...
            }
            );
            
        
        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "AnimGraph",
                "AnimGraphRuntime",
                "BlueprintGraph",
                "AnimMirroring"
                // ... add other public dependencies that you statically link with here ...
            }
            );
            
        
        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
        "Core",
        "CoreUObject",
        "Engine",
        "Slate",
        "SlateCore",
        "UnrealEd",
        "GraphEditor",
        "PropertyEditor",
        "EditorStyle",
        "ContentBrowser",
        "AnimMirroring",
        "AnimGraph",
        "AnimGraphRuntime",
        "RHI",
                // ... add private dependencies that you statically link with here ...    
            }
            );
        
        
        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
                // ... add any modules that your module loads dynamically here ...
            }
            );
    }
}
