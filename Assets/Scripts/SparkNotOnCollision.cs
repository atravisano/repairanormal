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

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == GameObjectName.name)
        {
            // disable spark
            EnableSpark(false);
        }
    }

    void OnCollisionExit(Collision other) 
    {
        EnableSpark(true);
    }

     void EnableSpark(bool isEnabled)
     {
        this.transform.GetChild(0).gameObject.SetActive(isEnabled);
     }
}
