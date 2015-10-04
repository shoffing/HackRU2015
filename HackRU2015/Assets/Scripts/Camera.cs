using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public Transform target;

    void Update() {
        var newPos = target.position + target.right * 6;
        newPos.y = 6;
        transform.position = newPos;
        transform.LookAt(target);
    }
}
