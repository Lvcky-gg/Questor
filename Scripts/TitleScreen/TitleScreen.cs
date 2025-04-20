using Godot;
using System;

public partial class TitleScreen : Control
{
	public void OnNewGamePressed()
	{
		Loader.Instance.LoadScene(this, "res://Scenes/game.tscn");
	}
}
