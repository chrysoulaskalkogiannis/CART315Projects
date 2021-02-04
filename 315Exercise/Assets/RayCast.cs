using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{


    public Camera maincamera;
    public GameObject prefab;

    int delay = 15;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
          delay = delay + 1;
          if (delay >=15) {



          Ray clickray = maincamera.ScreenPointToRay(Input.mousePosition);
          RaycastHit result;
          if (Physics.Raycast(clickray, out result))
          {
            GameObject.Instantiate(prefab, result.point, Quaternion.identity);
            }
            delay = 0;
          }
        }
        else {
          delay = 15;
        }
    }
}
