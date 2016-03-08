using UnityEngine;
using System.Collections;

public class stage : MonoBehaviour {
	private float delay = 0.0f; 
	private bool close;
	private CardboardHead head;
	public GameObject stage1;
	public GameObject output;
	public GameObject empty;

	void Start() 
	{
		stage1 = GameObject.Find ("stage1");
		stage1.renderer.material.color = Color.red;
		close = true;

	}

	void Update() 
	{
		head = Camera.main.GetComponent<StereoController>().Head;
		RaycastHit hit;
		bool isLookedAt = GetComponent<Collider>().Raycast(head.Gaze, out hit, Mathf.Infinity);
		// if looking at object for 2 seconds, enable/disable autowalk
		if (isLookedAt && Time.time > delay) { 
			if (close) {
				GameObject.Destroy(stage1);
				output.renderer.material.color=Color.yellow;

				Instantiate (output,empty.transform.position,empty.transform.rotation);

				close=false;

			}
			delay = Time.time + 2.0f;
			
		} 
	
		}
		

}
