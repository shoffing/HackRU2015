using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public Transform target;

    void Update() {
        transform.LookAt(target);
    }
}
