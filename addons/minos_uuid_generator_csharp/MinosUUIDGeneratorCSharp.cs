// Code written by Minoqi @2024 under the MIT license
// Documentation: https://github.com/Minoqi/minos-UUID-generator-for-godot

using Godot;
using System;
using System.Collections.Generic;

[Tool]
public static partial class MinosUUIDGeneratorCSharp : Object
{
	// Variables
	public static List<string> usedUUID = new List<string>();
	public static Godot.Collections.Array possibleCharacters = new Godot.Collections.Array {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

	// Debugging
	public static bool printNewUUID = true;
	public static bool printSuccessfulRemoval = true;
	public static bool printFailedRemoval = true;
	public static bool printNewUUIDNode = true;

	// Generate UUI
	static public string GenerateNewUUID(){
		// Variables
		string firstUUIDSection = "";
		string secondUUIDSection = "";
		string thirdUUIDSection = "";
		string fourthUUIDSection = "";
		string finalUUID = "";
		bool uuidExists = true;

		// Generate new UUID
		while (uuidExists){
			// Generate parts
			for (int i = 0; i < 8; i++){ // First section
				firstUUIDSection += possibleCharacters.PickRandom();
			}

			for (int i = 0; i < 4; i++){ // Second section
				secondUUIDSection += possibleCharacters.PickRandom();
			}

			for (int i = 0; i < 4; i++){ // Third section
				thirdUUIDSection += possibleCharacters.PickRandom();
			}

			for (int i = 0; i < 12; i++){ // Fourth section
				fourthUUIDSection += possibleCharacters.PickRandom();
			}

			// Put together and check if exists
			finalUUID = firstUUIDSection + "-" + secondUUIDSection + "-" + thirdUUIDSection + "-" + fourthUUIDSection;

			if (usedUUID.Contains(finalUUID)) {
				uuidExists = true;
			} else {
				uuidExists = false;
			}
		}

		// Store UUID as used
		usedUUID.Add(finalUUID);

		if (printNewUUID) {
			GD.Print("NEW UUID GENERATED - C#: " + finalUUID);
		}
		
		return finalUUID;
	}

	// Remove UUID
	static public void RemoveUUID(string _uuid){
		if (usedUUID.Contains(_uuid)) {
			usedUUID.Remove(_uuid);

			if (printSuccessfulRemoval) {
				GD.Print("UUID REMOVED - C#: " + _uuid);
			}
		} else {
			if (printFailedRemoval){
				GD.PushError("ATTEMPTED TO REMOVE UUI BUT UUID NOT FOUND - C#");
			}
		}
	}

	// Create UUID at runtime
	static public UUIDManagerCSharp CreateNewUUID(Node _parentNode) {
		var uuidNode = new UUIDManagerCSharp();
		_parentNode.AddChild(uuidNode);

		if (printNewUUIDNode) {
			GD.Print("NEW UUID NODE MADE - C#");
		}

		return uuidNode;
	}
}
