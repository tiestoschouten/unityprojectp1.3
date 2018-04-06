using UnityEngine;
using System.Collections;

public class guncontrolsfromtut : MonoBehaviour
{
	public GameObject Bullet_Emitter;

	public GameObject Bullet;

	public float Bullet_Up_Force;

	void Start ()
	{

	}

	void Update ()
	{
		if (Input.GetKeyDown("space"))
		{
			//The Bullet instantiation happens here.
			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate(Bullet,Bullet_Emitter.transform.position,Bullet_Emitter.transform.rotation) as GameObject;

		
			Temporary_Bullet_Handler.transform.Rotate(Vector3.up * 10);


			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

			Temporary_RigidBody.AddForce(transform.up * Bullet_Up_Force);

			Destroy(Temporary_Bullet_Handler, 2.0f);
		}
	}
}
//source https://www.youtube.com/watch?v=FD9HZB0Jn1w