using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 0.5f;
	public GameObject projectile;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") != 0f) 
		{
			gameObject.transform.Translate(0,speed * Input.GetAxis("Vertical"),0);
		}
		if (Input.GetAxis("Horizontal") != 0f)
		{
			gameObject.transform.Translate(speed * Input.GetAxis("Horizontal"),0,0);
		}
		if (Input.GetButtonDown("Fire1"))
		{
			Object theProjectile = Instantiate(projectile, transform.position, transform.rotation)as Object;
		}
	}
}
