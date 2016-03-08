using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour {


	public float colourChangeDelay=0.5f;
	float currentDelay=0f;
	bool colourChangeCollision= false;
	public float speed=1f;
	public GameObject wall;
	public GameObject wall2;
	public float movespeed = 10f;
	public float turnspeed =20f;
	public GameObject ObjecttoRotate;

	// Use this for initialization
	void Start () {
		wall= GameObject.Find("wall");
		wall2 = GameObject.Find ("wall2");

	}







	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up,-turnspeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up,-turnspeed * Time.deltaTime);
		
		checkColourChange ();
	
	}






	void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("contact was made!");
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;
	}

	void checkColourChange()
	{
		if (colourChangeCollision) {
			transform.GetComponent<Renderer> ().material.color = Color.yellow;
			if (Time.time > currentDelay) {
				transform.GetComponent<Renderer> ().material.color = Color.white;
				colourChangeCollision = false;
			}

		}
	}

	void OnCollisionStay (Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts) {
			print (contact.thisCollider.name + " hit " + contact.otherCollider.name);
			Debug.DrawRay (contact.point, contact.normal, Color.white);
		}
	}
	void RotateMyObject()
	{
		speed = GUI.HorizontalSlider(new Rect(35,75,200,30),speed,0.0f,50.0f);
		transform.localEulerAngles = new Vector3 (0.0f, speed, 0.0f);

	}

		




}
