using UnityEngine;
using System.Collections;

public class MoveToMousePoint : MonoBehaviour
{
	NavMeshAgent agent;

	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Ray mouse_ray;
		RaycastHit hit;
		if (Input.GetMouseButtonDown(0))
		{
			mouse_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(mouse_ray, out hit))
			{
				agent.SetDestination(hit.point);
			}
		}
	}
}
