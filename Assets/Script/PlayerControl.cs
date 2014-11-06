using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	private float run_speed_;
	private const float run_speed_max = 10.0f;
	private const float run_speed_add = 1.0f;
	private const float run_speed_sub = 5.0f*4.0f;

	private float attack_time = 0.0f;
	private const float attack_time_end = 1.2f;

	private bool is_running = true;
	private bool is_attack = false;
	private bool is_missing = false;

	private Animator animator;
	private string send_speed_hash = "speed";
	private string send_attack_hash = "isAttack";
	private string send_miss_hash = "isMiss";

	void Awake()
	{
		animator = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () 
	{
		run_speed_ = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (is_running)
		{
			run_speed_ += run_speed_add * Time.deltaTime;
		}
		else
		{
			run_speed_ -= run_speed_sub * Time.deltaTime;
		}
		run_speed_ = Mathf.Clamp (run_speed_, 0.0f, run_speed_max);

		//transform.position += new Vector3(run_speed_, 0.0f, 0.0f);

		if (is_attack)
		{
			Attack ();
		}
		else
		{
			if (Input.GetMouseButtonDown(0))
			{
				is_attack = true;
			}
		}

		if (is_missing)
		{
			Miss ();
		}

		animator.SetFloat (send_speed_hash, run_speed_);
		animator.SetBool (send_attack_hash, is_attack);
	}

	void Attack()
	{
		if (attack_time > attack_time_end)
		{
			is_attack = false;
			attack_time = 0.0f;
			return;
		}
		attack_time += Time.deltaTime;
	}

	void Miss()
	{

	}
}
