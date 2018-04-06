using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Edgebarrier : MonoBehaviour {
	public GameObject cube;

	void Ontriggerenter(GameObject cube) {
		Destroy(cube);
	}
}