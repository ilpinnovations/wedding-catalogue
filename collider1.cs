using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class collider1: MonoBehaviour {

	public GameObject box1;
	public GameObject cap1;
	public GameObject Cube;
	public GameObject pole;
	public GameObject Sphere;
	public GameObject Capsule;
	public Slider position;
	public float dist;
 

	// Use this for initialization
	void Start()
	{
		box1 = GameObject.Find ("box1");
		cap1 = GameObject.Find ("cap1");



	}
	void Update()
	{
		
	}



	void OnCollisonEnter(Collision collision)
	{
		position.enabled = true;
		Debug.Log ("violation");
		position.interactable=true;
		position.onValueChanged.AddListener (delegate {
			getReading ();
		});
	}

	void getReading(){

		float reading = position.value;
		Debug.Log (reading);
		dist = reading * 0.2f;
		setposition (dist);
	}



	void setposition(float dist)
	{
		transform.Translate (Vector3.left * dist * Time.deltaTime);
	}

}










/*void OnCollisionStay (Collision collision)
{
		foreach (ContactPoint contact in collision.contacts) {
			print (contact.thisCollider.name + " hit " + contact.otherCollider.name);
			Debug.DrawRay (contact.point, contact.normal, Color.white);


			Debug.Log ("collision occured");

		}
	}*/







