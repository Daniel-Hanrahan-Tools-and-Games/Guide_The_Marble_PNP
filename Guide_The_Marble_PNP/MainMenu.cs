using Godot;
using System;

public partial class MainMenu : Control
{
	
	// area RNG initialization
	Random intPotentialArea = new Random();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	// play button
	public void PlayButton(){
		// area RNG
		int intArea = intPotentialArea.Next(1, 11);
		// case statement for area
		switch(intArea)
		{
			case 1:
				// goes to room1
				GetTree().ChangeSceneToFile("res://room1.tscn");
				break;
			case 2:
				// goes to room2
				GetTree().ChangeSceneToFile("res://room2.tscn");
				break;
			case 3:
				// goes to room3
				GetTree().ChangeSceneToFile("res://room3.tscn");
				break;
			case 4:
				// goes to room4
				GetTree().ChangeSceneToFile("res://room4.tscn");
				break;
			case 5:
				// goes to room5
				GetTree().ChangeSceneToFile("res://room5.tscn");
				break;
			case 6:
				// goes to room6
				GetTree().ChangeSceneToFile("res://room6.tscn");
				break;
			case 7:
				// goes to room7
				GetTree().ChangeSceneToFile("res://room7.tscn");
				break;
			case 8:
				// goes to room8
				GetTree().ChangeSceneToFile("res://room8.tscn");
				break;
			case 9:
				// goes to room9
				GetTree().ChangeSceneToFile("res://room9.tscn");
				break;
	}
	}
	
	
	// exit button
	public void Exit()
	{
		GetTree().Quit();
	}
}
