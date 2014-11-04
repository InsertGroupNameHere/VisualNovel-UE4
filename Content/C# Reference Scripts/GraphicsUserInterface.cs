// C#
using UnityEngine;
using System.Collections;

public class GraphicsUserInterface : MonoBehaviour {
	
	void OnGUI () {
		// Make a group on the center of the screen

		// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
		
		// We'll make a box so you can see where the group is on-screen.

		GUI.Box    (new Rect (Screen.width/2-200, Screen.height/2-200, 400,400), "Main Menu");
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 150, 100, 50), "Start")) {
			Application.LoadLevel("scene");		}
		GUI.Button (new Rect (Screen.width/2-50, Screen.height/2-75,100,50), "Options");
		if(GUI.Button (new Rect (Screen.width/2-50, Screen.height /2, 100, 50), "Exit")){
			Application.Quit();
		GUI.EndGroup ();
	}
	
}
}