using UnityEngine;

public class Yolo : MonoBehaviour 
{
	public string Target;
	public Transform Spinee;

	// Use this for initialization
	void Start () 
	{
		Debug.Log("YOLO "+Target);

		Debug.Log("Live from a "+UnityEngine.iOS.Device.generation+" device!");
	}

	void Update ()
	{
		var particles = GetComponent<ParticleSystem>();
		particles.startColor = Color.red;

		Spinee.eulerAngles += new Vector3(0f, 0f, 1f);
	}
}
