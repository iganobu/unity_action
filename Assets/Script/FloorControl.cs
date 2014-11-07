using UnityEngine;
using System.Collections;

public class FloorControl : MonoBehaviour 
{
	public static float floor_width = 10.0f;
	public static int model_num = 3;

	Vector3 initialPosition;

	GameObject mainCamera;

	// Use this for initialization
	void Start () 
	{
		initialPosition = transform.position;
		mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () 
	{
		float totalWidth = floor_width * model_num;
		Vector3 cameraPosition = mainCamera.transform.position;
		float distance = cameraPosition.x - this.initialPosition.x;

		int n = Mathf.RoundToInt ( distance / totalWidth );

		Vector3 position = this.initialPosition;
		position.x += n * totalWidth;
		this.transform.position = position;
	}
}
