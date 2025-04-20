using Godot;
using System;

public partial class GameManager : Node
{
	public static string DefaultMapPath;
	public static string CurrentMapPath;

	public static void StartNewGame()
	{
		CurrentMapPath = DefaultMapPath;
	}
}
