using UnityEngine;
using System.Collections;

public class GoToIntro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > 3.0f) {
			Application.LoadLevel("Intro");
		}
	}
}
