using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	public float chargeRate = 0.05f;
	public float regenRate = 0.05f;
	public float maxEnergy = 20f;
	public float drainRate = 20f;

	private float energy;
	private float shield;
	private float missleCharge;
	private float beamCharge;
	private float projectileCharge;
	private bool isCharging;
	// Use this for initialization
	void Start () {
		energy = maxEnergy;
		isCharging = false;
	}
	
	// Update is called once per frame
	void Update () {
		regenEnergy();
		if(isCharging)
		{
			missleCharge+= chargeRate*Time.deltaTime;
			drainEnergy(drainRate);
		}
	}

	void regenEnergy()
	{
		if(energy <= maxEnergy)
		{
			if((energy + (regenRate*Time.deltaTime) > maxEnergy))
			{
				energy = maxEnergy;
			} else {
				energy += regenRate*Time.deltaTime;
				Debug.Log(""+energy);
			}
		}
	}

	public void drainEnergy(float drainAmount)
	{
		float amount = drainAmount *  Time.deltaTime;
		if(energy - amount < 0)
		{
			energy = 0; 
			isCharging = false;
		} else {
			energy -= amount;
		}
	}

	public void setCharging(bool charging)
	{
		if(charging == false)
		{
			missleCharge = 0f;
		}
		isCharging = charging;
	}

	public bool getCharging()
	{
		return isCharging;
	}

	public float getChargeLevel()
	{
		return missleCharge;
	}
}
