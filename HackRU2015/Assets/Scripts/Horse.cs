using UnityEngine;
using System.Collections;

public class Horse : MonoBehaviour {

    public Rigidbody rigidbody;

    void Update() {
        rigidbody.AddForce(rigidbody.transform.right * -25);

        if(Input.GetKeyDown("space")) {
            rigidbody.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }

}
