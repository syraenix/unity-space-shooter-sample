using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	public float speed;

	void Start()
	{
		Rigidbody rigidbody = GetComponent<Rigidbody> () as Rigidbody;
		rigidbody.velocity = transform.forward * speed;
	}
}
