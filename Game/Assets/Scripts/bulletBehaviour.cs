using UnityEngine;
using System.Collections;

public class bulletBehaviour : MonoBehaviour {
	public float speed = 0.2f;
	public float damage = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,speed,0);
	}

	void OnTriggerEnter2D(Collider2D theObject){
		Destroy(gameObject);
	}
}
