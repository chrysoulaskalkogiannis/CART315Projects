using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


public float accelerate = 0.5f;

public float shipRotate = 0.25f;

public float accelerationFactor = 1.0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {




        if (Input.GetKey(KeyCode.W)){
        this.GetComponent<Rigidbody>().AddForce(this.transform.forward * (accelerate * accelerationFactor));

      } else if (Input.GetKey(KeyCode.S)) {
        this.GetComponent<Rigidbody>().AddForce(this.transform.forward * (-accelerate * accelerationFactor));

      } if (Input.GetKey(KeyCode.A)) {
        this.GetComponent<Rigidbody>().AddForce(this.transform.right * (-accelerate * accelerationFactor));
        this.transform.Rotate(0,-shipRotate,0);

      } else if (Input.GetKey(KeyCode.D)) {
        this.GetComponent<Rigidbody>().AddForce(this.transform.right * (accelerate * accelerationFactor));
        this.transform.Rotate(0,shipRotate,0);

      }


    }
}




// gameobject.rigidbody.AddForce(gameobject.transform.forward * (desired speed * accelerationFactor));

// this.GetComponent<Transform>()
