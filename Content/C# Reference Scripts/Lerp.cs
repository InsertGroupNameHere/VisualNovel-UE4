using UnityEngine;
using System.Collections;

public class Lerp : MonoBehaviour
{
	public GameObject posA;
	public GameObject posB;

	private bool myTrigger = false;
	private float timePast = 0.0f; 



		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update (){
		    if (Input.GetKeyDown (KeyCode.KeypadEnter)){
						myTrigger = true;
		}
	        if(myTrigger){
		    timePast += Time.deltaTime;
			transform.position = Vector3.Lerp (posA.transform.position, posB.transform.position, timePast);
				}
		}

}
		




