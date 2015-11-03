using UnityEngine;
using System.Collections;

public class Yolo : MonoBehaviour 
{
	public string Target;
	public Transform Spinee;

	// Use this for initialization
	void Start () 
	{
		Debug.Log("YOLO "+Target);
	}

	void Update ()
	{
		var particles = GetComponent<ParticleSystem>();
		particles.startColor = Color.red;

		Spinee.eulerAngles += new Vector3(0f, 0f, 1f);
	}
}
