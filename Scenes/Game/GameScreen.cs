using Godot;
using System;

public partial class GameScreen : Node
{
	[Export] public Node map;
	public override void _Ready()
	{
		var packedScene = GameManager.CurrentMap; 
		var instance = packedScene.Instantiate();
		map.AddChild(instance);
	}

}
