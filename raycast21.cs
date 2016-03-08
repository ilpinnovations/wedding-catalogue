using UnityEngine;
using System.Collections;

public class raycast21 : MonoBehaviour {
	public float colourChangeDelay=0.5f;
	float currentDelay=0f;
	bool colourChangeCollision= false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		/*var hit: RaycastHit;
		var ray: Ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,hit,10.0))
		{
			if(hit.collider.tag=="Cube")
			{
				var renderer: Renderer=WheelHit.collider.renderer;
			renderer.material.color=Color.yellow;
			print("hitobject");

			}
		}
*/






	//	ChangeColor();



		checkColourChange ();
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

	/*void ChangeColor() {
		while(true){
			this.camera.backgroundColor = Color32(Random.Range(0, 255), Random.Range(0, 255),     Random.Range(0, 255), 1);
			//yield WaitForSeconds(5);
		}
	}*/




}
