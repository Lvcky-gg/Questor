using Godot;
using System;

public partial class TitleScreen : Control
{
	public void OnNewGamePressed()
	{
		GameManager.StartNewGame();
		Loader.Instance.LoadScene(this, "res://Scenes/game.tscn");
	}
}
