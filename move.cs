using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public GameObject redLight;
	public GameObject greenLight;
	public GameObject yellowLight;

	// Use this for initialization
	void Start () {
		yellowLight = GameObject.Find ("yellowLight");
		redLight = GameObject.Find ("redLight");
		greenLight = GameObject.Find ("greenLight"); 
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision){
	if(redLight.renderer.material.color==Color.red){
			Debug.Log("violation");
		}

}
}
