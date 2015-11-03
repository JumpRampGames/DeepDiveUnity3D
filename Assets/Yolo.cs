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
	}
}
