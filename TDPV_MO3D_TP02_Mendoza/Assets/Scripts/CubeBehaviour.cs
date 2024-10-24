using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

    public float speed = 5f;
    public float rotationSpeed = 50f;

    public void Movement(Vector3 direction){
        transform.position += direction * speed * Time.deltaTime;
    }

    public void Rotation(Vector3 direction) {
        if (direction != Vector3.zero){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
        }
    }

}
