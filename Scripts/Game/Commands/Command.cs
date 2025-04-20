using Godot;
using System;

[GlobalClass]
public partial class Command : Resource
{
	[Export] public string CommandLabel;

	[Signal] public delegate void CommandProcessedEventHandler(string label);

	public void Execute()
	{
		GD.Print($"Executing: {CommandLabel}");
		EmitSignal(SignalName.CommandProcessed, CommandLabel);
	}
}
