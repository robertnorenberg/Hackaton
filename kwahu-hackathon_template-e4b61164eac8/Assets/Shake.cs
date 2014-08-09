using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour {

	private Vector3 shake = new Vector3(0.0f,0.0f,0.0f);


	void Update () {

		Vector3 old_shake = shake;
		shake = new Vector3(0.0f, Random.Range (-0.1f, 0.1f), 0.0f);

		gameObject.transform.position -= old_shake + shake;


	
	}
}
