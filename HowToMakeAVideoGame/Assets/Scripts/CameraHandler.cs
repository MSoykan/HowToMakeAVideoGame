using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    private void Update() {
        transform.position = player.position + offset;
    }
}
