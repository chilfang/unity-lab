using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSphereScript : MonoBehaviour {
    private void FixedUpdate() {
        if (gameObject.transform.position.y < -10) {
            Destroy(gameObject);
        }
    }
}
