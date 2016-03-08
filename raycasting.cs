	using UnityEngine;
	using System.Collections;

	public class raycasting : MonoBehaviour {
		 public static bool violation=false;
		public GameObject wall1;
		public GameObject wall2;
		public  int count=0;

		public GameObject object1;
	RaycastHit hit;
	Vector3 fwd;
		// Use this for initialization
		void Start () {
			
			wall1 = GameObject.Find ("wall1");
			wall2 = GameObject.Find ("wall2");
			object1 = GameObject.Find ("object1"); 
			InvokeRepeating ("detect", 0.01f, 1.0f);

	}
	
		// Update is called once per frame
		void Update () {

	 fwd = transform.TransformDirection (Vector3.right);
		}
	void detect()
	{
	
		
		if (Physics.Raycast (transform.position, fwd, out hit, 5.0f))
		{
			
			if (hit.collider.gameObject.name.Contains ("wall")) 
			{
				if (hit.distance >3) 
				{
					violation=true;
					count++;
					//Debug.Log("distance greater than 3");
				}	
				
				else 
				{
					//Debug.Log("distance less than 3");
					if(count==0)
						violation = false;
					else {
						if(violation==true)
						{
							violation=false;

							Debug.Log ("violation");
						}
					}
				}
				
			}
			
		}

	}
}



