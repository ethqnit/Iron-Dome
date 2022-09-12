using Godot;
using System;

public class Button : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void _on_Button_pressed()
    {
        GD.Print("Check button");
        GetTree().ChangeScene("res://scenes/Game.tscn");
    }
}
