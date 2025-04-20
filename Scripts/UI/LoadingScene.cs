using Godot;
using System;

public partial class LoadingScene : Control
{
	[Export] private TextureProgressBar loadingBar;

	public override void _Ready()
	{
		Loader.Instance.Connect("LoadingProgressUpdatedEventHandler", new Callable(this, nameof(OnProgressUpdated)));

	}

	private void OnProgressUpdated(float percentage)
	{

		loadingBar.Value = percentage;
	}
}
