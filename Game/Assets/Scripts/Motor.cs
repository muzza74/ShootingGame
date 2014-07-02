using UnityEngine;
using System.Collections;

public enum theAxes{x,y};

public class Motor : MonoBehaviour {
	public Vector3 velocity;
	public float deceleration = 0.04f;
	private float xTarget;
	private float yTarget;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		updateVelocity();
		transform.Translate(velocity);
	}

	public void setVelocity(Vector3 newVelocity)
	{
		velocity = newVelocity;
	}

	// updates the current vector target for velocity
	public void updateAxis(theAxes axis, float value)
	{
		if (axis == theAxes.x)
		{
			xTarget = value;
		}
		if(axis == theAxes.y)
		{
			yTarget = value;
		}
	}

	void updateVelocity ()
	{
		velocity.x = xTarget;
		velocity.y = yTarget;
		if(xTarget > 0)
		{
			if((xTarget - deceleration) < 0)
			{
				xTarget = 0;
			} else {
				xTarget -= deceleration;
			}
		} else if (xTarget < 0)
		{
			if((xTarget + deceleration) > 0)
			{
				xTarget = 0;
			} else {
				xTarget += deceleration;
			}
		}
		if(yTarget > 0)
		{
			if((yTarget - deceleration) < 0)
			{
				yTarget = 0;
			} else {
				yTarget -= deceleration;
			}
		} else if (yTarget < 0)
		{
			if((yTarget + deceleration) > 0)
			{
				yTarget = 0;
			} else {
				yTarget += deceleration;
			}
		}
	}
}
