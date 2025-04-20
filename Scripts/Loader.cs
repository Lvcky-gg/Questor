using Godot;
using System;

public partial class Loader : Node
{
		[Export] private Node _loadingScene;
		private String _scenePath;
		[Signal] public delegate void LoadingProgressUpdatedEventHandler(float percentage);
		public static Loader Instance;

	public override void _Ready()
	{
		var scene = (PackedScene)ResourceLoader.Load("res://Scenes/UI/loading_scene.tscn");
		_loadingScene = scene.Instantiate();
		Instance = this;

	}
	public void LoadScene(Node caller,String path)
	{
		_scenePath = path;
		
		GetTree().Root.AddChild(_loadingScene);
		ResourceLoader.LoadThreadedRequest(_scenePath);
		
		caller.QueueFree();
	}
	public override void _Process(double delta)
	{
		if( _scenePath != null){
		var Progress = new Godot.Collections.Array();
		var LoaderStatus = ResourceLoader.LoadThreadedGetStatus(_scenePath, Progress);
		
		if(LoaderStatus == ResourceLoader.ThreadLoadStatus.Loaded)
		{
			var packedScene = (PackedScene)ResourceLoader.LoadThreadedGet(_scenePath);
			var _loadedScene = packedScene.Instantiate();
			GetTree().Root.RemoveChild(_loadingScene);
			GetTree().Root.AddChild(_loadedScene);
			
			_scenePath = null;
		}
		else if(LoaderStatus == ResourceLoader.ThreadLoadStatus.InProgress)
		{
			EmitSignal("LoadingProgressUpdatedEventHandler", Progress[0]);
		}
		}
	}
}
