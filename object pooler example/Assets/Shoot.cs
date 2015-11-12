using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public ObjectPoolScript BulletPool;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// check for input to shoot bullet
		if (Input.GetButtonDown("Fire1")){

			// get object from the pool
			GameObject NewBullet = BulletPool.FetchObject();

			// put new object ontop of object that is shooting it
			NewBullet.transform.position = transform.position;

			// turn object on
			NewBullet.SetActive(true);

			// add velocity so that bullet moves
			NewBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);


		}
	}
}
