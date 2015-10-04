using UnityEngine;
using System.Collections;

public class Horse : MonoBehaviour {

    public Rigidbody rigidbody;

    void Update() {
        rigidbody.AddForce(rigidbody.transform.right * -50);
    }

}
