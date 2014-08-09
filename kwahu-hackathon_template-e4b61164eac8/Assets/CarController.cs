using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	// Use this for initialization
	public float timer = 0.0f;
	private bool flag = false;
	public string answer;
	void Start () {

	}

	
	// Update is called once per frame
	void Update () {
		timer = timer+ Time.deltaTime;
		if(timer > 5 && flag == false)
		licznik ();


		
		answer = Dialoguer.GetGlobalString(0);

		if (answer == "fail") {
			Debug.Log ("FAIL");
		} else if (answer == "ok") {
			Debug.Log ("OK");	
		}
	}
	void licznik(){
		flag = true;
		Dialoguer.StartDialogue (6);

		}


		


}
