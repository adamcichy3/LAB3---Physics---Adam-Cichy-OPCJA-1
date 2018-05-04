using UnityEngine;
using System.Collections;

public class glueScript : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 15) * Time.deltaTime);
	}

	void OnCollisionEnter(Collision collision) {
		collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
		collision.gameObject.GetComponent<Rigidbody>().freezeRotation = true;
		collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
		collision.gameObject.GetComponent<Collider>().enabled = false;
		collision.transform.localRotation=Quaternion.identity;
		collision.gameObject.transform.parent = transform;

		//collision.transform.localPosition=Vector3.zero;

/*
		float x = collision.gameObject.transform.parent.localScale.x;
		float y = collision.gameObject.transform.parent.localScale.y;
		float z = collision.gameObject.transform.parent.localScale.z;
*/

		/*
		collision.transform.localScale = new Vector3 (x / collision.gameObject.transform.parent.localScale.x,
		                                             y / collision.gameObject.transform.parent.localScale.y,
		                                             z / collision.gameObject.transform.parent.localScale.z);
*/
		collision.transform.localScale = new Vector3 ( .02f,.02f,0.02f);

	}
}
