using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{

public Vector3 rotation = new Vector3(0, 0.05f, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        this.GetComponent<Transform>().Rotate(rotation);

    }
}
