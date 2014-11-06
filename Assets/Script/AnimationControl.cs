using UnityEngine;
using System.Collections;

public class AnimationControl : MonoBehaviour 
{
	public Animator animator;

	NavMeshAgent agent;
	float send_speed;

	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		send_speed = agent.velocity.magnitude;
		animator.SetFloat ("speed", send_speed);
		//Debug.Log (send_speed);
	}
}
