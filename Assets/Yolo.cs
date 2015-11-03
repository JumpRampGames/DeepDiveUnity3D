using UnityEngine;
using System.Collections;

public class Yolo : MonoBehaviour 
{
	public string Target;

	// Use this for initialization
	void Start () 
	{
		Debug.Log("YOLO "+Target);
	}

	void Update ()
	{
		var particles = GetComponent<ParticleSystem>();
		particles.startColor = Color.red;

		var capsule = GetComponent<Transform>();
		capsule.eulerAngles += new Vector3(0f, 0f, 1f);
	}
}
