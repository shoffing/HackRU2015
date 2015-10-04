using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

     void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Horse") {
            foreach (ContactPoint contact in collision.contacts) {
                // BOUNCY CASTLE
                collision.rigidbody.AddForce(contact.normal * 300);
            }
        }
    }

}
