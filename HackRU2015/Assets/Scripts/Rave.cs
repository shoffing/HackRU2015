using UnityEngine;
using System.Collections;

public class Rave : MonoBehaviour {

	private const float RATE = 20f;

	private Light lt;
	private float offset;
	private float oo1, oo2, oo3;

	void Start() {
		lt = GetComponent<Light>();

		offset = Random.value * Mathf.PI;
		oo1 = Random.value * 100;
		oo2 = Random.value * 100;
		oo3 = Random.value * 100;
	}

	void Update() {
		transform.parent.Rotate(new Vector3(0, 5, 0));

		lt.color = new Color(
			1f + 0.5f * Mathf.Sin(offset + Time.time * RATE + oo1),
			1f + 0.5f * Mathf.Cos(offset + Time.time * RATE + oo2),
			1f + 0.5f * Mathf.Sin(offset + Time.time * RATE + oo3)
		);
	}

}
