using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}


	//Update normal
//	void Update(){
//		if (Input.GetMouseButton (1)) {
//			Camera.main.transform.RotateAround (Vector3.zero, Vector3.up, 20 * Time.deltaTime);
//		}
//	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
