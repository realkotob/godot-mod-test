using Godot;
using System;

public class Main : Node2D
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        ItemList list = this.GetNode(@"Panel/ItemList") as ItemList;
        list.AddItem("Hello from C#!");
        
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
