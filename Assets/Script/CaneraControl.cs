using UnityEngine;
using System.Collections;

public class CaneraControl : MonoBehaviour 
{
	private GameObject targetObject;

	private static Vector3 camera_range = new Vector3(0, 4, -10.0f); 

	void Awake()
	{
		targetObject = GameObject.FindGameObjectWithTag("Player");
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (targetObject.transform.position.x, camera_range.y, camera_range.z);
	}
}
