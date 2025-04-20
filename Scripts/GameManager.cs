using Godot;
using System;

public partial class GameManager : Node
{
	public static string DefaultMapPath = "res://Scenes/Game/Maps/tile_map.tscn";
	public static string CurrentMapPath;

	public static void StartNewGame()
	{
		CurrentMapPath = DefaultMapPath;
	}
	public static PackedScene CurrentMap => GD.Load<PackedScene>(CurrentMapPath);
}
