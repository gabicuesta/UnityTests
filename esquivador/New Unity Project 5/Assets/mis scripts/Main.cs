using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public float timer = 15; // set duration time in seconds in the Inspector
	public GameObject prefab;
	public int numberOfObjects = 10;
	public float radius = 180;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime; // I need timer which from a particular time goes to zero
		
		if (timer > 0)
		{
			//print("no: " + timer);
		} 
		else // timer is <= 0
		{
			print("yes");

			for (int i = 0; i < numberOfObjects; i++) {
				float angle = i * Mathf.PI * 2 / numberOfObjects;
				//Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
				Vector3 pos = new Vector3(-0.5f, 7.63f, -0.76f);
				Instantiate(prefab, pos, Quaternion.identity);
			}

			timer = 15;
		}
	
	}
}
