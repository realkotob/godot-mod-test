using Godot;
using System;
using System.Linq;
using System.Reflection;
using Directory = System.IO.Directory;

public class Main : Node2D
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    private const string PluginsDirectoryName = "Plugins";

    public override void _Ready()
    {
        this.PopulatePluginAssemblies();
    }

    private void PopulatePluginAssemblies()
    {
        ItemList list = this.GetNode(@"Panel/ItemList") as ItemList;
        
        if (Directory.Exists(PluginsDirectoryName)) {
            var allFiles = Directory.GetFiles(PluginsDirectoryName, "*.dll");

            foreach (var fileName in allFiles) {
                var assembly = Assembly.LoadFile(fileName);
                list.AddItem(assembly.FullName);
            }
        } else {
            list.AddItem("Plugins directory doesn't exist.");
        }
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
