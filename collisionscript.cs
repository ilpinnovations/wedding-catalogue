using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {

	public GameObject wall;
	public GameObject wall2;



// Use this for initialization
void Start()
{
		wall= GameObject.Find("wall");
		wall2 = GameObject.Find ("wall2");

}
 void Update()
	{
	}



	void OnCollisionStay (Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts) {
			print (contact.thisCollider.name + " hit " + contact.otherCollider.name);
			Debug.DrawRay (contact.point, contact.normal, Color.white);
		}
	}
}
	


