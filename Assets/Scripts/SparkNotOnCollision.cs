using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkNotOnCollision : MonoBehaviour
{
    public GameObject GameObjectName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Enter" + col.gameObject.name);
        if (col.gameObject.name == GameObjectName.name)
        {
            // disable spark
            EnableSpark(false);
            col.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    void OnTriggerExit(Collider other) 
    {
        Debug.Log("Exit" + other.gameObject.name);
        EnableSpark(true);
    }

     void EnableSpark(bool isEnabled)
     {
        this.transform.GetChild(0).gameObject.SetActive(isEnabled);
     }
}
