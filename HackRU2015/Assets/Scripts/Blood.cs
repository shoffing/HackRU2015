using UnityEngine;
using System.Collections;

public class Blood : MonoBehaviour {

	void Start() {
        StartCoroutine(WaitAndDie());
    }

    IEnumerator WaitAndDie() {
        yield return new WaitForSeconds(2);
        //Destroy(gameObject);
    }

}
