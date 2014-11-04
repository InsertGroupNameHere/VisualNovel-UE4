using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour
{
	public static float Health = 1000;
	public float currentHealth = 100;
	private int clicks;
	public bool myTrigger;



	
	// Use this for initialization
	public void Start ()
	{
	}
	
	// Update is called once per frame
	public void Update (){

		//limiting the jump function
		 
		if (Input.GetKeyDown (KeyCode.Space)) {
						clicks--;
						Debug.Log ("Jump has been pressed and Health is " + Health);
						Health -= 20;
		
				} else if (Health < 1000) 
						Health += Time.deltaTime * 10;
				  }

	public void Game() {
		if (Health <= 0) {
		
		}

			
		
		}
		
	}
	


	

			
			
		

		

