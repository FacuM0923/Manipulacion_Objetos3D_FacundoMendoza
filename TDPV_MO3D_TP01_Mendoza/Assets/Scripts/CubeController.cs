using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private CubeBehaviour cubeBehaviour;

    void Start(){
        cubeBehaviour = GetComponent<CubeBehaviour>();
    }

    void Update(){

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        cubeBehaviour.Movement(movementDirection);
        cubeBehaviour.Rotation(movementDirection);

    }

}
