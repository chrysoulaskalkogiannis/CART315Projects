using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{

  public string pickUpTag;


  private void OnCollisionEnter(Collision collision)
{
    if (collision.collider.gameObject.CompareTag(pickUpTag))
    {
        Debug.Log("gwrggwg");
        Destroy(collision.collider.gameObject);
    }

}



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
