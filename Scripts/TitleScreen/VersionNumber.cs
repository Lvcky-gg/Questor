using Godot;
using System;

public partial class VersionNumber : Label
{
	public override void _Ready()
	{
		Text = Text + ProjectSettings.GetSetting("application/config/version");
	}
}
