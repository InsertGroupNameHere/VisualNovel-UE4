using UnityEngine;
using System.Collections;

public class LiveGUI : MonoBehaviour
{
	    
	
		// Use this for initialization
		void OnGUI ()
		{
		float  h1 = HealthSystem.Health;
		string h2 = h1.ToString ();
		GUI.Label  (new Rect (0,0,400,400), h2);
		}
	
		// Update is called once per frame
		void Update ()
		{

	
		}
}

