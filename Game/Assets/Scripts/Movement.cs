using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 0.5f;
	public GameObject projectile;

	private Vector3 inputVector;
	private Motor theMotor;
	private PlayerManager theManager;
	private bool chargingWeapon;
	// Use this for initialization
	void Start () {
		theMotor = gameObject.GetComponent<Motor>();
		theManager = gameObject.GetComponent<PlayerManager>();
	}
	
	// Update is called once per frame
	void Update () {
		float vert = Input.GetAxis("Vertical");
		float hori = Input.GetAxis("Horizontal");
		if (vert != 0f) 
		{
			theMotor.updateAxis(theAxes.y, (speed * vert));
		} else {
			inputVector.y = 0f;
		}
		if (hori != 0f)
		{
			theMotor.updateAxis(theAxes.x, (speed * hori));
		} else {
			inputVector.x = 0f;
		}
		if (Input.GetButtonDown("Fire1"))
		{
			if(chargingWeapon)
			{
				GameObject theProjectile = Instantiate(projectile, transform.position, transform.rotation)as GameObject;
				theProjectile.GetComponent<missleBehaviour>().chargeLevel = theManager.getChargeLevel();
				theManager.setCharging(false);
				chargingWeapon = false;
			} else {
				theManager.setCharging(true);
				chargingWeapon = true;
			}
		}
	}
}
