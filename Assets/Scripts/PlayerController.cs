using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    float speed;
    Rigidbody rigidbody;

    Vector3 direction;

    void Start() {
        //setup 
        speed = 0.25f;
        rigidbody = gameObject.AddComponent<Rigidbody>();

        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update() {
        direction = Vector3.zero;

        Vector3 forwardValue = transform.forward;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) { direction += forwardValue; }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) { direction += Quaternion.Euler(0, -90, 0) * forwardValue; }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) { direction += Quaternion.Euler(0, 90, 0) * forwardValue; }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) { direction -= forwardValue; }
    }

    private void FixedUpdate() {
        rigidbody.AddForce(direction.normalized * speed, ForceMode.Impulse);
    }
}
