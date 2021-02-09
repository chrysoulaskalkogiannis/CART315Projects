using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

public Vector3 forward = new Vector3(0, 0, 0.5f);

public Vector3 rotation = new Vector3(0, 0.5f, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
      {


        this.GetComponent<Transform>().Translate(forward);
      } else if (Input.GetKey(KeyCode.S)) {
        this.GetComponent<Transform>().Translate(-forward);
      }
      if (Input.GetKey(KeyCode.A))
      {
this.GetComponent<Transform>().Rotate(-rotation);


      }else if (Input.GetKey(KeyCode.D)){

        this.GetComponent<Transform>().Rotate(rotation);
      }
    }
}
