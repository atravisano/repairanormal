using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cablebox : MonoBehaviour
{
    public GameObject LeftCollisionObject;
    public GameObject RightCollisionObject;

    public float Delay;
    private float timeUntilSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            
        }
    }

    string GetLeftPlugName()
    {
        return this.transform.GetChild(1).gameObject.name;
    }
    string GetRightPlugName()
    {
        return this.transform.GetChild(0).gameObject.name;
    }

}
