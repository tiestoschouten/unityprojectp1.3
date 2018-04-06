using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guncontroller : MonoBehaviour {
	public float rotationSpeed;
	void Update () {

		float xInput = Input.GetAxisRaw ("Horizontal");
		transform.Rotate (new Vector3 (0, 0, xInput * -1) * rotationSpeed * Time.deltaTime);



	}
}
