// Code written by Minoqi @2024 under the MIT license
// Documentation: https://github.com/Minoqi/minos-UUID-generator-for-godot

using Godot;
using System;

[Tool]
[GlobalClass, Icon("res://addons/minos_uuid_generator/uuidIcon.svg")]
public partial class UUIDManagerCSharp : Node
{
	// Variables
	public string uuid = "";

	public override void _EnterTree() {
		if (uuid == "") { // Fail safe
			uuid = MinosUUIDGeneratorCSharp.GenerateNewUUID();
		}
	}

	public override void _ExitTree() {
		MinosUUIDGeneratorCSharp.RemoveUUID(uuid);
	}
}
