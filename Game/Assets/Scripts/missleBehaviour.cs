using UnityEngine;
using System.Collections;

public class missleBehaviour : MonoBehaviour {
	public float baseAccelleration = 5f;
	public float maxSpeed = 5f;
	public float damage = 2f;
	public float chargeLevel = 0f;
	private float currentSpeed = 0f;
	// Use this for initialization
	void Start () {
		currentSpeed = 0f;
		//chargeLevel = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,currentSpeed,0);
		if(currentSpeed < maxSpeed)
		{
			currentSpeed += baseAccelleration * chargeLevel * Time.deltaTime;
		} else {
			currentSpeed = maxSpeed;
		}
	}

	void OnTriggerEnter2D(Collider2D theObject){
		Destroy(gameObject);
	}
}
