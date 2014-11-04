using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public static GameCamera cam;
	private bool myTrigger;
	private int clicks;


	void Start () {
		cam = GetComponent<GameCamera>();
		SpawnPlayer();
	 }

	void PauseGame (){
				if (Input.GetKeyDown (KeyCode.LeftControl)) {
						clicks++;
						Time.timeScale = 0;
				} else if (Input.GetKeyDown (KeyCode.RightCommand)) {
						Time.timeScale = 1;
				}
		}




    private void SpawnPlayer() {
	  cam.SetTarget((Instantiate(player,Vector3.zero,Quaternion.identity) as GameObject).transform);
	}

   void DieRespawn() {
  
		}
					

	
	void Update () {
	
	}
}

