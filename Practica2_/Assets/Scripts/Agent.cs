using UnityEngine;

public class Agent : SBAgent
{
	public Transform target;
	//public Transform target2;

	void Start()
	{
		maxSpeed = 10f;
		maxSteer = 1f;

		target = GameObject.Find("Target").transform;
		
	}

	void Update()
	{
		velocity += SteeringBehaviours.Arrive(this, target, 3);
		//velocity += SteeringBehaviours.Flee(this, target2, 1);
		transform.position += velocity * Time.deltaTime;
		velocity += SteeringBehaviours.Seek(this, target, 1f);


	}
}
