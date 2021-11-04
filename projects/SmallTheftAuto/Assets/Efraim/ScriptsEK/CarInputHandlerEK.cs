using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandlerEK : MonoBehaviour {
    //components
    CarControllerEK carController;

    private void Awake() {
        carController = GetComponent<CarControllerEK>();
    }

    private void Update() {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        carController.SetInputVector(inputVector);
    }
}
