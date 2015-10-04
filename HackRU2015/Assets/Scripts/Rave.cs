using UnityEngine;
using System.Collections;

public class Rave : MonoBehaviour {
	public int bpm = 120;
	public Color randColor;
	public Light lt;

	void Start() {
		lt = GetComponent<Light>();
		randColor = new Color(Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1F));
		lt.color = randColor;

		StartCoroutine(beginSequence());
	}

	void Update() {
	}

	IEnumerator beginSequence()
	{
		for (int i = 0; i < 100; i++) {
			turnOffLights ();
		
			yield return 1;
		
			turnOnLights ();
		}
	}

	void turnOffLights() {
		lt.enabled = false;
	}

	void turnOnLights() {
		lt.enabled = true;
	}
}
