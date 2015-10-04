using UnityEngine;
using System.Collections;

public class DancingHorse : MonoBehaviour {

    private float health = 1f;

    void Start () {
        GetComponent<Animator>().SetFloat("DanceOffset", Random.value);
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Horse") {
            // Deal damage to ourselves
            Damage(0.5f);

            foreach (ContactPoint contact in collision.contacts) {
                // Create blood particle
                GameObject blood = Instantiate(Resources.Load("Prefabs/Blood", typeof(GameObject)), contact.point, Quaternion.LookRotation(contact.normal * -1, Vector3.up)) as GameObject;
                blood.transform.SetParent(transform);
            }
        }
    }

    void Damage(float amount) {
        health -= amount;

        if(health <= 0) {
            Destroy(gameObject);
        }
    }

}
