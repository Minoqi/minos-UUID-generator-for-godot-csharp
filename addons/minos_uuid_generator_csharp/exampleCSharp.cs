using Godot;
using System;

public partial class exampleCSharp : Node2D
{
	// Variables
	[Export]
	UUIDManagerCSharp uuidNode;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		uuidNode = MinosUUIDGeneratorCSharp.CreateNewUUID(this);
	}
}
