using UnityEngine;
using System.Collections;

public class DialoguerExampleStart : MonoBehaviour {

	void Awake(){
		// You must initialize Dialoguer before using it!
		Dialoguer.Initialize();
	}

	void Start()
	{
		// show dialog nr 4!!!!
		// remember after adding new one, click tools, dialogouer, generate enum shit

	}

	void OnGUI()
	{
		GUILayout.Label ("dupa");
	}
}
