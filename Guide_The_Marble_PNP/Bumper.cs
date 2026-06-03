using Godot;
using System;

public partial class Bumper : Area2D
{
	[Export] public float BounceStrength = 800f;

	public override void _Ready()
	{
		// Connect to collision signal
		BodyEntered += Collision;
	}

	public void Collision(Node2D Player){
		// calls playerscript
		Player playerScript = GetNode<Player>("../Player");
		// increases hits taken
		playerScript.intHitsTaken -= 2;
	}
}
