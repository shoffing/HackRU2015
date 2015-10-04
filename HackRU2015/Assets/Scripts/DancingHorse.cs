using UnityEngine;
using System.Collections;

public class DancingHorse : MonoBehaviour {

    private float health = 1f;

    private bool touching;

    public AudioSource[] whinnies;

    void Start () {
        GetComponent<Animator>().SetFloat("DanceOffset", Random.value);
    }

    void FixedUpdate() {
        if(touching) {
            Damage(0.05f);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Horse") {
            // Play a whinny
            if(whinnies.Length > 0) {
                whinnies[(int) (Random.value * whinnies.Length)].Play();
            }

            // Deal damage to ourselves
            touching = true;

            foreach (ContactPoint contact in collision.contacts) {
                // Create blood particle
                GameObject blood = Instantiate(Resources.Load("Prefabs/Blood", typeof(GameObject)), contact.point, Quaternion.LookRotation(contact.normal * -1, Vector3.up)) as GameObject;
                blood.transform.SetParent(transform);
            }
        }
    }

    void OnCollisionExit(Collision collision) {
        if(collision.gameObject.tag == "Horse") {
            // Stop dealing damage to ourselves
            touching = false;
        }
    }

    void Damage(float amount) {
        health -= amount;

        if(health <= 0) {
            Destroy(gameObject);
        }
    }

}
